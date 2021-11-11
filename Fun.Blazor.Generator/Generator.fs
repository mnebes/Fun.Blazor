﻿module Fun.Blazor.Generator.Generator

open System
open System.Reflection
open Microsoft.AspNetCore.Components
open Fun.Blazor

open Utils



let private getMetaInfo (ty: Type) =
    let rawProps = ty.GetProperties()
    let validProps = getValidBlazorProps ty rawProps

    let props =
        validProps
        |> Seq.map (fun prop ->
            let name = lowerFirstCase prop.Name
            let name =
                if fsharpKeywords |> List.contains name then $"{name}'"
                else name

            let _createNode = $"|> {nameof GenericFunBlazorNode}<{funBlazorGeneric}>.create"
            let _boleroCreateNode = $"|> {nameof BoleroAttr} {_createNode}"

            let createBindableProps (propTypeName: string) =
                if isBindable prop validProps then
                    [
                        $"    static member {name}' (value: IStore<{propTypeName}>) = {nameof GenericFunBlazorNode}<{funBlazorGeneric}>.create(\"{prop.Name}\", value)"
                        $"    static member {name}' (value: cval<{propTypeName}>) = {nameof GenericFunBlazorNode}<{funBlazorGeneric}>.create(\"{prop.Name}\", value)"
                    ]
                else
                    []

            if prop.PropertyType.IsGenericType then
                if prop.PropertyType.Name.StartsWith "EventCallback" ||
                    prop.PropertyType.Name.StartsWith "Microsoft.AspNetCore.Components.EventCallback"
                then
                    [ $"    static member {name} fn = (Bolero.Html.attr.callback<{getTypeName prop.PropertyType.GenericTypeArguments.[0]}> \"{prop.Name}\" (fun e -> fn e)) {_boleroCreateNode}" ]
                elif prop.PropertyType.Name.StartsWith "RenderFragment`" then
                    [ $"    static member {name} (render: {getTypeName prop.PropertyType.GenericTypeArguments.[0]} -> {nameof IFunBlazorNode}) = Bolero.Html.attr.fragmentWith \"{prop.Name}\" (fun x -> render x |> html.toBolero) {_boleroCreateNode}" ]
                elif prop.PropertyType.Namespace = "System" && prop.PropertyType.Name.StartsWith "Func`" then
                    let returnType = prop.PropertyType.GenericTypeArguments |> Seq.last
                    if returnType = typeof<Microsoft.AspNetCore.Components.RenderFragment> then
                        let paramCount = prop.PropertyType.Name.Substring("Func`".Length) |> int
                        let parameters = [for i in 1..paramCount-1 do $"x{i}"] |> String.concat " "
                        [ $"    static member {name} (fn) = Bolero.FragmentAttr (\"{prop.Name}\", fun render -> box ({getTypeName prop.PropertyType}(fun {parameters} -> Microsoft.AspNetCore.Components.RenderFragment(fun rt -> render rt (html.toBolero(fn {parameters})))))) {_boleroCreateNode}"  ]
                    else
                        [ $"    static member {name} (fn) = \"{prop.Name}\" => ({getTypeName prop.PropertyType}fn) {_boleroCreateNode}" ]
                elif prop.PropertyType.Namespace = "System" && prop.PropertyType.Name.StartsWith "Action`" then
                    [ $"    static member {name} (fn) = \"{prop.Name}\" => ({getTypeName prop.PropertyType}fn) {_boleroCreateNode}" ]
                else
                    let propTypeName = getTypeName prop.PropertyType
                    [
                        $"    static member {name} (x: {propTypeName}) = \"{prop.Name}\" => x {_boleroCreateNode}"
                        yield! createBindableProps propTypeName
                    ]

            elif prop.PropertyType = typeof<RenderFragment> then
                [
                    $"    static member {name} (x: string) = Bolero.Html.attr.fragment \"{prop.Name}\" (html.text x |> html.toBolero) {_boleroCreateNode}"
                    $"    static member {name} (node) = Bolero.Html.attr.fragment \"{prop.Name}\" (html.toBolero node) {_boleroCreateNode}"
                    $"    static member {name} (nodes) = Bolero.Html.attr.fragment \"{prop.Name}\" (nodes |> html.fragment |> html.toBolero) {_boleroCreateNode}"
                ]

            elif prop.Name = "Class" && prop.PropertyType = typeof<string> then
                [ $"    static member classes (x: string list) = attr.classes x {_createNode}" ]

            elif prop.Name = "Style" && prop.PropertyType = typeof<string> then
                [ $"    static member styles (x: (string * string) list) = attr.styles x {_createNode}" ]
            else
                let propTypeName = getTypeName prop.PropertyType
                [
                    $"    static member {name} (x: {propTypeName}) = \"{prop.Name}\" => x {_boleroCreateNode}"
                    yield! createBindableProps propTypeName
                ])

        |> Seq.concat
        |> String.concat "\n"


    let getTypeMeta (ty: Type) =
        if ty.Name.Contains "`" then
            let generics =
                if ty.GenericTypeArguments.Length = 0 then
                    ty.GetTypeInfo().GenericTypeParameters
                else
                    ty.GenericTypeArguments
                |> Seq.toList
            ty, generics
        else
            ty, []

    let inherits =
        if ty.BaseType <> typeof<Microsoft.AspNetCore.Components.ComponentBase> then
            Some (getTypeMeta ty.BaseType)
        else
            None

    let name, generics, inheritInfo =
        match getTypeMeta ty, inherits with
        | (name, generics), Some (baseName, generics') -> 
            let generics = List.append generics' generics |> List.distinctBy (fun x -> x.Name) |> List.filter (fun x -> (getTypeName x).StartsWith "'")
            name, generics, Some (baseName, generics')

        | (name, generics), None ->
            name, generics, None

    let hasChildren = props.Contains "static member childContent"
    {| ty = ty; generics = generics; inheritInfo = inheritInfo; props = props; hasChildren = hasChildren |}



type private TypeTree =
    | Node of Type * TypeTree seq

let rec private getTypeTree (baseType: Type) (tys: Type seq): TypeTree seq =
    let baseTypeName = baseType.Namespace + "." + baseType.Name
    tys
    |> Seq.filter (fun x ->
        if baseType.IsGenericType && x.BaseType <> null then
             baseTypeName = x.BaseType.Namespace + "." + x.BaseType.Name
        else
            x.BaseType = baseType)
    |> Seq.map (fun ty -> Node (ty, getTypeTree ty tys))


let private getMetaInfos (tys: Type seq) =
    let rec getNamespaces tree =
        tree 
        |> Seq.map (fun (Node (ty, childTys)) -> ty.Namespace::(getNamespaces childTys |> Seq.toList))
        |> Seq.concat

    let rec getTypesInNamespace tree ns =
        tree
        |> Seq.map (fun (Node (ty, childTys)) ->
            [
                if ty.Namespace = ns then ty
                yield! getTypesInNamespace childTys ns
            ])
        |> Seq.concat

    let rec getRootNamespaces (nss: string list) =
        match nss with
        | [] -> []
        | [ns] -> [ns]
        | ns::rest ->
            let _, p2 = rest |> List.partition (fun x -> x.StartsWith ns)
            ns::getRootNamespaces p2

    let rec getOrderedTypes tree =
        tree
        |> Seq.map (fun (Node (ty, childTys)) ->
            [
                ty
                yield! getOrderedTypes childTys
            ])
        |> Seq.concat

    let tree = tys |> Seq.filter (fun x -> x.IsAssignableTo typeof<ComponentBase> && x.IsPublic) |> getTypeTree typeof<ComponentBase>
    let namespaces = getNamespaces tree |> Seq.toList
    let metaGroups = System.Collections.Generic.List<_>()
    
    tree
    |> getOrderedTypes
    |> Seq.map getMetaInfo
    |> Seq.iter (fun meta ->
        if metaGroups.Count = 0 then
            metaGroups.Add(meta.ty.Namespace, [meta])
        else
            let ns, metas = metaGroups |> Seq.last
            if ns = meta.ty.Namespace then metaGroups.[metaGroups.Count-1] <- (ns, metas@[meta])
            else metaGroups.Add(meta.ty.Namespace, [meta]))

    {| 
        rootNamespaces = getRootNamespaces namespaces
        metas = metaGroups
    |}


let generateCode (targetNamespace: string) (opens: string) (tys: Type seq) =
    let metaInfos = getMetaInfos tys

    let getFinalTypeName = getTypeShortName >> lowerFirstCase >> avoidFsharpKeywords

    let trimNamespace (ns: string) =
        metaInfos.rootNamespaces
        |> Seq.pick (fun x ->
            if ns.StartsWith x then
                if ns.Length = x.Length then Some ""
                else ns.Substring(x.Length + 1) |> Some
            else
                None)

    let internalCode =
        metaInfos.metas
        |> Seq.map (fun (ns, metas) ->
            let code =
                metas
                |> Seq.map (fun meta ->
                    let originalTypeWithGenerics = $"{meta.ty.Namespace}.{getTypeShortName meta.ty}{meta.generics |> getTypeNames |> createGenerics |> closeGenerics}"

                    let inheirit' =
                        match meta.inheritInfo with
                        | None -> ""
                        | Some (ty, generics) -> $"inherit {ty.Namespace |> trimNamespace |> appendStrIfNotEmpty (string '.')}{getFinalTypeName ty}{ funBlazorGeneric::(getTypeNames generics) |> createGenerics |> closeGenerics }"

                    let ref = $"    static member ref x = attr.ref<{originalTypeWithGenerics}> x |> {nameof GenericFunBlazorNode}<{funBlazorGeneric}>.create"
                    
                    let create1 = $"    static member create () = [] |> html.blazor<{originalTypeWithGenerics}>"
                    
                    let create2 =
                        if meta.props.Length > 0 then
                            $"    static member create (nodes: {nameof GenericFunBlazorNode}<{funBlazorGeneric}> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<{originalTypeWithGenerics}>"
                        else
                            ""

                    let create3 =
                        if meta.hasChildren then
                            $"    static member create (nodes: {nameof IFunBlazorNode} list) = nodes |> html.blazor<{originalTypeWithGenerics}>"
                            + "\n"+
                            $"    static member create (node: {nameof IFunBlazorNode}) = [ node ] |> html.blazor<{originalTypeWithGenerics}>"
                            + "\n"+
                            $"    static member create (x: string) = [ html.text x ] |> html.blazor<{originalTypeWithGenerics}>"
                        else
                            ""

                    $"""
type {getFinalTypeName meta.ty}{funBlazorGeneric::(getTypeNames meta.generics) |> createGenerics |> appendStr (createConstraint meta.generics) |> closeGenerics} =
    {inheirit'}
{create1}
{create2}
{create3}
{ref}
{meta.props}
                    """)
                |> String.concat "\n"
            
            $"""namespace rec {targetNamespace}.{internalSegment}{ns |> trimNamespace |> addStrIfNotEmpty "."}

{opens}
open {targetNamespace}.{internalSegment}

{code}
            """)
        |> String.concat "\n"


    let dslCode =
        metaInfos.metas
        |> Seq.map (fun (ns, metas) ->
            let code =
                metas
                |> Seq.map (fun meta ->
                    let interfaceTy = $"I{meta.ty |> getTypeShortName}Node{meta.generics |> getTypeNames |> createGenerics |> closeGenerics}"

                    $"""
type { interfaceTy } = interface end
type { getFinalTypeName meta.ty }{ meta.generics |> getTypeNames |> createGenerics |> appendStr (createConstraint meta.generics) |> closeGenerics } =
    class
        inherit {ns |> trimNamespace |> appendStrIfNotEmpty "."}{getFinalTypeName meta.ty}{interfaceTy::(getTypeNames meta.generics) |> createGenerics |> closeGenerics }
    end
                    """)
                |> String.concat "\n"

            $"""namespace {targetNamespace}{ns |> trimNamespace |> addStrIfNotEmpty "."}

open {targetNamespace}.{internalSegment}

{ code }
            """)
        |> String.concat "\n"

    {| internalCode= internalCode; dslCode = dslCode |}

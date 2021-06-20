﻿module Fun.Blazor.Generator.Utils

open System
open System.Reflection


let lowerFirstCase (str: string) =
    if String.IsNullOrEmpty str then ""
    elif str.Length = 1 then str.ToLower()
    else str.Substring(0, 1).ToLower() + str.Substring(1, str.Length - 1)


let funBlazorGeneric = "'FunBlazorGeneric"


let createGenerics (strs: string seq) =
    if Seq.length strs = 0 then ""
    else strs |> String.concat ", "
    
let closeGenerics str =
    if String.IsNullOrEmpty str then ""
    else sprintf "<%s>" str


let getTypeShortName (ty: Type) =
    if ty.Name.Contains "`" then ty.Name.Split("`").[0]
    else ty.Name

 
let rec getTypeName (ty: Type) =
    let interfaces = ty.GetInterfaces()
    let isIEnumerable, isList, isDictionary = 
        interfaces 
        |> Seq.fold
            (fun (isIEnumerable, isList, isDictionary) x -> 
                if x.Namespace = "System.Collections.Generic" then
                    if x.Name.StartsWith "Dictionary`" then Some x, isList, Some x
                    elif x.Name.StartsWith "List`" then Some x, Some x, isDictionary
                    elif x.Name.StartsWith "IEnumerable`" then Some x, isList, isDictionary
                    else isIEnumerable, isList, isDictionary
                else isIEnumerable, isList, isDictionary)
            (None, None, None)
    
    let getName (ty: Type)  = 
        if ty.Name.Contains "`" then
            let generics =
                ty.GenericTypeArguments
                |> Seq.map getTypeName
                |> String.concat ", "
                |> fun x ->
                    if String.IsNullOrEmpty x then ""
                    else $"<{x}>"
            let name = ty.Name.Split('`').[0]
            $"{ty.Namespace}.{name}{generics}"

        elif String.IsNullOrEmpty ty.FullName |> not then 
            if ty.FullName.Contains "+" then $"{ty.ReflectedType.FullName}.{ty.Name}"
            else ty.FullName

        else
            $"'{ty.Name}"

    if ty = typeof<string> then "System.String"
    else
        if ty.IsArray then
            match isIEnumerable with
            | Some e -> $"{getTypeName e.GenericTypeArguments.[0]}[]"
            | None -> getName ty
        else
            match isList with
            | Some e -> $"System.Collections.Generic.List<{getTypeName e.GenericTypeArguments.[0]}>"
            | None ->
                match isDictionary with
                | Some e -> $"System.Collections.Generic.Dictionary<{getTypeName e.GenericTypeArguments.[0]}>"
                | None -> getName ty


let getTypeNames (tys: Type list) = List.map getTypeName tys


let createConstraint (tys: Type list) =
    tys
    |> List.filter (fun x -> x.IsGenericParameter)
    |> List.map (fun x ->
        let tyConstraints = x.GetGenericParameterConstraints()
        [
            if x.GenericParameterAttributes = GenericParameterAttributes.ReferenceTypeConstraint then
                $"'{x.Name} : not struct"
            yield!
                tyConstraints
                |> Seq.filter (fun x -> String.IsNullOrEmpty x.FullName |> not)
                |> Seq.map (fun ty -> $"'{x.Name} :> {ty.FullName}")
        ])
    |> List.concat
    |> String.concat " and "
    |> fun x ->
        if String.IsNullOrEmpty x then ""
        else $" when {x}"


let appendStr (x: string) (y: string) = y + x

let appendStrIfNotEmpty (x: string) (y: string) =
    if String.IsNullOrEmpty y then ""
    else y + x

let addStrIfNotEmpty (x: string) (y: string) =
    if String.IsNullOrEmpty y then ""
    else x + y

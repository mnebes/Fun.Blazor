﻿namespace Fun.Blazor

open System


type FunBlazorNode =
    | Elt of tag: string * FunBlazorNode list
    | Attr of key: string * value: Choice<string, bool>
    | Fragment of FunBlazorNode list
    | Text of string
    | BoleroNode of Bolero.Node
    | BoleroAttr of Bolero.Attr
    | BoleroAttrs of Bolero.Attr list

    static member GetBoleroNodesAndAttrs nodes =
        let rec getBoleroNodeAndAttrs nodes =
            nodes 
            |> Seq.fold
                (fun (nodes, attrs) x ->
                    match x with
                    | Attr (k, Choice1Of2 v) -> nodes, attrs@[ Bolero.Attr (k, v) ]
                    | Attr (k, Choice2Of2 true) -> nodes, attrs@[ Bolero.Attr (k, null) ]
                    | Attr _ -> nodes, attrs
                    | BoleroAttr x -> nodes, attrs@[x]
                    | BoleroAttrs x -> nodes, attrs@x
                    | node ->
                        let node =
                            match node with
                            | Elt (tag, nodes) ->
                                let nodes, attrs = getBoleroNodeAndAttrs nodes
                                Bolero.Elt(tag, attrs, nodes)
                            | Fragment nodes ->
                                let nodes, _ = getBoleroNodeAndAttrs nodes
                                Bolero.Concat nodes
                            | Text x ->
                                Bolero.Text x
                            | BoleroNode x ->
                                x
                            | BoleroAttr _
                            | BoleroAttrs _
                            | Attr _ ->
                                Bolero.Empty
                        nodes@[node], attrs)
                ([], [])
        getBoleroNodeAndAttrs nodes

    static member ToBoleroNode node =
        let nodes, _ = FunBlazorNode.GetBoleroNodesAndAttrs [ node ]
        Bolero.ForEach nodes

    member this.ToBoleroNode () = FunBlazorNode.ToBoleroNode this


type [<Struct>] GenericFelizNode<'T> =
    { Node: FunBlazorNode }

    static member create x: GenericFelizNode<'T> = { Node = x }


type IComponentHook =
    abstract ParametersSet: IEvent<unit>
    abstract Initialized: IEvent<unit>
    abstract AfterRender: IEvent<bool>
    abstract Dispose: IEvent<unit>
    abstract AddDispose: IDisposable -> unit
    abstract StateHasChanged: unit -> unit


type IStore<'T> =
    abstract Publish: ('T -> 'T) -> unit
    abstract Publish: 'T -> unit
    abstract Observable: IObservable<'T>
    abstract Current: 'T

type ILocalStore =
    abstract Create: 'T -> IStore<'T>

type IShareStore =
    abstract Create: string * 'T -> IStore<'T>
    abstract Create: 'T -> IStore<'T>
    
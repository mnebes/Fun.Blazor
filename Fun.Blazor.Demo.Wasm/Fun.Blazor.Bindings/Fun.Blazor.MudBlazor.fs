namespace rec Fun.Blazor.MudBlazor.DslInternals

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.MudBlazor.DslInternals


type mudComponentBase<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<MudBlazor.MudComponentBase>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudComponentBase>

    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudBaseButton<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudBaseButton>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudBaseButton>

    static member inline htmlTag (x: System.String) = "HtmlTag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline buttonType (x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline link (x: System.String) = "Link" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableElevation (x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableRipple (x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudButton<'FunBlazorGeneric> =
    inherit mudBaseButton<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudButton>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudButton>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudButton>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudButton>
    static member inline startIcon (x: System.String) = "StartIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline endIcon (x: System.String) = "EndIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconColor (x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconClass (x: System.String) = "IconClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline variant (x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline htmlTag (x: System.String) = "HtmlTag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline buttonType (x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline link (x: System.String) = "Link" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableElevation (x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableRipple (x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudFab<'FunBlazorGeneric> =
    inherit mudBaseButton<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudFab>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudFab>

    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconColor (x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconSize (x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline htmlTag (x: System.String) = "HtmlTag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline buttonType (x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline link (x: System.String) = "Link" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableElevation (x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableRipple (x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudIconButton<'FunBlazorGeneric> =
    inherit mudBaseButton<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudIconButton>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudIconButton>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudIconButton>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudIconButton>
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline edge (x: MudBlazor.Edge) = "Edge" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline variant (x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline htmlTag (x: System.String) = "HtmlTag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline buttonType (x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline link (x: System.String) = "Link" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableElevation (x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableRipple (x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudMenu<'FunBlazorGeneric> =
    inherit mudBaseButton<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudMenu>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudMenu>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudMenu>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudMenu>
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconColor (x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline startIcon (x: System.String) = "StartIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline endIcon (x: System.String) = "EndIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline variant (x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxHeight (x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline positionAtCurser (x: System.Boolean) = "PositionAtCurser" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activatorContent (x: string) = Bolero.Html.attr.fragment "ActivatorContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activatorContent (node) = Bolero.Html.attr.fragment "ActivatorContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activatorContent (nodes) = Bolero.Html.attr.fragment "ActivatorContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activationEvent (x: MudBlazor.MouseEvent) = "ActivationEvent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline direction (x: MudBlazor.Direction) = "Direction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offsetY (x: System.Boolean) = "OffsetY" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offsetX (x: System.Boolean) = "OffsetX" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline htmlTag (x: System.String) = "HtmlTag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline buttonType (x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline link (x: System.String) = "Link" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableElevation (x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableRipple (x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudFileUploader<'FunBlazorGeneric> =
    inherit mudBaseButton<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudFileUploader>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudFileUploader>

    static member inline htmlTag (x: System.String) = "HtmlTag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline buttonType (x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline link (x: System.String) = "Link" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableElevation (x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableRipple (x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudBaseItemsControl<'FunBlazorGeneric, 'TChildComponent when 'TChildComponent :> MudBlazor.MudComponentBase> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudBaseItemsControl<'TChildComponent>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudBaseItemsControl<'TChildComponent>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudBaseItemsControl<'TChildComponent>>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudBaseItemsControl<'TChildComponent>>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedIndex (x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedIndexChanged fn = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudBaseSelectItem<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudBaseSelectItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudBaseSelectItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudBaseSelectItem>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudBaseSelectItem>
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableRipple (x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudNavLink<'FunBlazorGeneric> =
    inherit mudBaseSelectItem<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudNavLink>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudNavLink>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudNavLink>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudNavLink>
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconColor (x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline match' (x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableRipple (x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudSelectItem<'FunBlazorGeneric, 'T> =
    inherit mudBaseSelectItem<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudSelectItem<'T>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudSelectItem<'T>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudSelectItem<'T>>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudSelectItem<'T>>
    static member inline value (x: 'T) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableRipple (x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudFormComponent<'FunBlazorGeneric, 'T, 'U> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudFormComponent<'T, 'U>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudFormComponent<'T, 'U>>

    static member inline required (x: System.Boolean) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline requiredError (x: System.String) = "RequiredError" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline errorText (x: System.String) = "ErrorText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline error (x: System.Boolean) = "Error" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline converter (x: MudBlazor.Converter<'T, 'U>) = "Converter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline culture (x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validation (x: System.Object) = "Validation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline for' (x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudAlert<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudAlert>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudAlert>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudAlert>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudAlert>
    static member inline elevation (x: System.Int32) = "Elevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline square (x: System.Boolean) = "Square" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noIcon (x: System.Boolean) = "NoIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline severity (x: MudBlazor.Severity) = "Severity" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline variant (x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudAppBar<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudAppBar>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudAppBar>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudAppBar>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudAppBar>
    static member inline elevation (x: System.Int32) = "Elevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fixed' (x: System.Boolean) = "Fixed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudAvatar<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudAvatar>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudAvatar>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudAvatar>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudAvatar>
    static member inline square (x: System.Boolean) = "Square" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rounded (x: System.Boolean) = "Rounded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline image (x: System.String) = "Image" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudBadge<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudBadge>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudBadge>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudBadge>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudBadge>
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bottom (x: System.Boolean) = "Bottom" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline left (x: System.Boolean) = "Left" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline start (x: System.Boolean) = "Start" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dot (x: System.Boolean) = "Dot" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlap (x: System.Boolean) = "Overlap" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline max (x: System.Int32) = "Max" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline content (x: System.Object) = "Content" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudBreadcrumbs<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudBreadcrumbs>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudBreadcrumbs>

    static member inline items (x: System.Collections.Generic.List<MudBlazor.BreadcrumbItem>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline separator (x: System.String) = "Separator" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline separatorTemplate (x: string) = Bolero.Html.attr.fragment "SeparatorTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline separatorTemplate (node) = Bolero.Html.attr.fragment "SeparatorTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline separatorTemplate (nodes) = Bolero.Html.attr.fragment "SeparatorTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (render: MudBlazor.BreadcrumbItem -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxItems (x: System.Nullable<System.Byte>) = "MaxItems" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudButtonGroup<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudButtonGroup>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudButtonGroup>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudButtonGroup>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudButtonGroup>
    static member inline overrideStyles (x: System.Boolean) = "OverrideStyles" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline verticalAlign (x: System.Boolean) = "VerticalAlign" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableElevation (x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline variant (x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudToggleIconButton<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudToggleIconButton>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudToggleIconButton>

    static member inline toggled (x: System.Boolean) = "Toggled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline toggledChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ToggledChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline toggledIcon (x: System.String) = "ToggledIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline toggledTitle (x: System.String) = "ToggledTitle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline toggledColor (x: MudBlazor.Color) = "ToggledColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline toggledSize (x: MudBlazor.Size) = "ToggledSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline edge (x: MudBlazor.Edge) = "Edge" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableRipple (x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline variant (x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudCard<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudCard>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudCard>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudCard>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudCard>
    static member inline elevation (x: System.Int32) = "Elevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline square (x: System.Boolean) = "Square" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudCardActions<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudCardActions>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudCardActions>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudCardActions>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudCardActions>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudCardContent<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudCardContent>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudCardContent>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudCardContent>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudCardContent>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudCardHeader<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudCardHeader>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudCardHeader>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudCardHeader>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudCardHeader>
    static member inline cardHeaderAvatar (x: string) = Bolero.Html.attr.fragment "CardHeaderAvatar" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cardHeaderAvatar (node) = Bolero.Html.attr.fragment "CardHeaderAvatar" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cardHeaderAvatar (nodes) = Bolero.Html.attr.fragment "CardHeaderAvatar" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cardHeaderContent (x: string) = Bolero.Html.attr.fragment "CardHeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cardHeaderContent (node) = Bolero.Html.attr.fragment "CardHeaderContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cardHeaderContent (nodes) = Bolero.Html.attr.fragment "CardHeaderContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cardHeaderActions (x: string) = Bolero.Html.attr.fragment "CardHeaderActions" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cardHeaderActions (node) = Bolero.Html.attr.fragment "CardHeaderActions" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cardHeaderActions (nodes) = Bolero.Html.attr.fragment "CardHeaderActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudCardMedia<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudCardMedia>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudCardMedia>

    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline image (x: System.String) = "Image" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.Int32) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudCarouselItem<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudCarouselItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudCarouselItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudCarouselItem>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudCarouselItem>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline transition (x: MudBlazor.Transition) = "Transition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline customTransitionEnter (x: System.String) = "CustomTransitionEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline customTransitionExit (x: System.String) = "CustomTransitionExit" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudChartBase<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudChartBase>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudChartBase>

    static member inline inputData (x: System.Double[]) = "InputData" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputLabels (x: System.String[]) = "InputLabels" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xAxisLabels (x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartSeries (x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartOptions (x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartType (x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline legendPosition (x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedIndex (x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedIndexChanged fn = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudChart<'FunBlazorGeneric> =
    inherit mudChartBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudChart>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudChart>

    static member inline inputData (x: System.Double[]) = "InputData" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputLabels (x: System.String[]) = "InputLabels" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xAxisLabels (x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartSeries (x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartOptions (x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartType (x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline legendPosition (x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedIndex (x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedIndexChanged fn = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Fun.Blazor.MudBlazor.DslInternals.Charts

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.MudBlazor.DslInternals


type bar<'FunBlazorGeneric> =
    inherit mudChartBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.Charts.Bar>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.Charts.Bar>

    static member inline inputData (x: System.Double[]) = "InputData" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputLabels (x: System.String[]) = "InputLabels" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xAxisLabels (x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartSeries (x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartOptions (x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartType (x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline legendPosition (x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedIndex (x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedIndexChanged fn = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type donut<'FunBlazorGeneric> =
    inherit mudChartBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.Charts.Donut>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.Charts.Donut>

    static member inline inputData (x: System.Double[]) = "InputData" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputLabels (x: System.String[]) = "InputLabels" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xAxisLabels (x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartSeries (x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartOptions (x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartType (x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline legendPosition (x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedIndex (x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedIndexChanged fn = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type line<'FunBlazorGeneric> =
    inherit mudChartBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.Charts.Line>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.Charts.Line>

    static member inline inputData (x: System.Double[]) = "InputData" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputLabels (x: System.String[]) = "InputLabels" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xAxisLabels (x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartSeries (x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartOptions (x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartType (x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline legendPosition (x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedIndex (x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedIndexChanged fn = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type pie<'FunBlazorGeneric> =
    inherit mudChartBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.Charts.Pie>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.Charts.Pie>

    static member inline inputData (x: System.Double[]) = "InputData" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputLabels (x: System.String[]) = "InputLabels" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xAxisLabels (x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartSeries (x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartOptions (x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartType (x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline legendPosition (x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedIndex (x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedIndexChanged fn = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type legend<'FunBlazorGeneric> =
    inherit mudChartBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.Charts.Legend>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.Charts.Legend>

    static member inline data (x: System.Collections.Generic.List<MudBlazor.Charts.SVG.Models.SvgLegend>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputData (x: System.Double[]) = "InputData" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputLabels (x: System.String[]) = "InputLabels" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xAxisLabels (x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartSeries (x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartOptions (x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline chartType (x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline legendPosition (x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedIndex (x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedIndexChanged fn = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Fun.Blazor.MudBlazor.DslInternals

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.MudBlazor.DslInternals


type mudChipSet<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudChipSet>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudChipSet>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudChipSet>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudChipSet>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline multiSelection (x: System.Boolean) = "MultiSelection" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mandatory (x: System.Boolean) = "Mandatory" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allClosable (x: System.Boolean) = "AllClosable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline filter (x: System.Boolean) = "Filter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedChip (x: MudBlazor.MudChip) = "SelectedChip" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedChipChanged fn = (Bolero.Html.attr.callback<MudBlazor.MudChip> "SelectedChipChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedChips (x: MudBlazor.MudChip[]) = "SelectedChips" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedChipsChanged fn = (Bolero.Html.attr.callback<MudBlazor.MudChip[]> "SelectedChipsChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClose fn = (Bolero.Html.attr.callback<MudBlazor.MudChip> "OnClose" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudChip<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudChip>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudChip>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudChip>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudChip>
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline variant (x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatar (x: System.String) = "Avatar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatarClass (x: System.String) = "AvatarClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.Boolean) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconColor (x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closeIcon (x: System.String) = "CloseIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableRipple (x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline link (x: System.String) = "Link" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline text (x: System.String) = "Text" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline forceLoad (x: System.Boolean) = "ForceLoad" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline default' (x: System.Boolean) = "Default" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClose fn = (Bolero.Html.attr.callback<MudBlazor.MudChip> "OnClose" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudCollapse<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudCollapse>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudCollapse>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudCollapse>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudCollapse>
    static member inline expanded (x: System.Boolean) = "Expanded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxHeight (x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onAnimationEnd (x: Microsoft.AspNetCore.Components.EventCallback) = "OnAnimationEnd" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudDialog<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudDialog>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudDialog>

    static member inline titleContent (x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleContent (node) = Bolero.Html.attr.fragment "TitleContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleContent (nodes) = Bolero.Html.attr.fragment "TitleContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dialogContent (x: string) = Bolero.Html.attr.fragment "DialogContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dialogContent (node) = Bolero.Html.attr.fragment "DialogContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dialogContent (nodes) = Bolero.Html.attr.fragment "DialogContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dialogActions (x: string) = Bolero.Html.attr.fragment "DialogActions" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dialogActions (node) = Bolero.Html.attr.fragment "DialogActions" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dialogActions (nodes) = Bolero.Html.attr.fragment "DialogActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableSidePadding (x: System.Boolean) = "DisableSidePadding" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classContent (x: System.String) = "ClassContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classActions (x: System.String) = "ClassActions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline contentStyle (x: System.String) = "ContentStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isVisible (x: System.Boolean) = "IsVisible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isVisibleChanged fn = (Bolero.Html.attr.callback<System.Boolean> "IsVisibleChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudDialogInstance<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudDialogInstance>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudDialogInstance>

    static member inline options (x: MudBlazor.DialogOptions) = "Options" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleContent (x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleContent (node) = Bolero.Html.attr.fragment "TitleContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleContent (nodes) = Bolero.Html.attr.fragment "TitleContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline content (x: string) = Bolero.Html.attr.fragment "Content" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline content (node) = Bolero.Html.attr.fragment "Content" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline content (nodes) = Bolero.Html.attr.fragment "Content" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.Guid) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudDrawer<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudDrawer>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudDrawer>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudDrawer>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudDrawer>
    static member inline fixed' (x: System.Boolean) = "Fixed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline elevation (x: System.Int32) = "Elevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchor (x: MudBlazor.Anchor) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline variant (x: MudBlazor.DrawerVariant) = "Variant" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableOverlay (x: System.Boolean) = "DisableOverlay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline preserveOpenState (x: System.Boolean) = "PreserveOpenState" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline openMiniOnHover (x: System.Boolean) = "OpenMiniOnHover" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline breakpoint (x: MudBlazor.Breakpoint) = "Breakpoint" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline openChanged fn = (Bolero.Html.attr.callback<System.Boolean> "OpenChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline miniWidth (x: System.String) = "MiniWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline clipMode (x: MudBlazor.DrawerClipMode) = "ClipMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudDrawerContainer<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudDrawerContainer>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudDrawerContainer>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudDrawerContainer>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudDrawerContainer>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudLayout<'FunBlazorGeneric> =
    inherit mudDrawerContainer<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudLayout>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudLayout>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudLayout>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudLayout>
    static member inline rightToLeft (x: System.Boolean) = "RightToLeft" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudElement<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudElement>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudElement>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudElement>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudElement>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline htmlTag (x: System.String) = "HtmlTag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ref (x: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = "Ref" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refChanged fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ElementReference> "RefChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudExpansionPanel<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudExpansionPanel>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudExpansionPanel>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudExpansionPanel>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudExpansionPanel>
    static member inline maxHeight (x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleContent (x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleContent (node) = Bolero.Html.attr.fragment "TitleContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleContent (nodes) = Bolero.Html.attr.fragment "TitleContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline text (x: System.String) = "Text" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideIcon (x: System.Boolean) = "HideIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableGutters (x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isExpandedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "IsExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isExpanded (x: System.Boolean) = "IsExpanded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudExpansionPanels<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudExpansionPanels>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudExpansionPanels>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudExpansionPanels>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudExpansionPanels>
    static member inline square (x: System.Boolean) = "Square" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline multiExpansion (x: System.Boolean) = "MultiExpansion" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline elevation (x: System.Int32) = "Elevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableGutters (x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableBorders (x: System.Boolean) = "DisableBorders" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudField<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudField>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudField>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudField>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudField>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline margin (x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline error (x: System.Boolean) = "Error" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline errorText (x: System.String) = "ErrorText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline variant (x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline adornmentIcon (x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline adornmentText (x: System.String) = "AdornmentText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline adornment (x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconSize (x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onAdornmentClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline innerPadding (x: System.Boolean) = "InnerPadding" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableUnderLine (x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudFocusTrap<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudFocusTrap>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudFocusTrap>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudFocusTrap>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudFocusTrap>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultFocus (x: MudBlazor.DefaultFocus) = "DefaultFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudForm<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudForm>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudForm>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudForm>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudForm>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isValid (x: System.Boolean) = "IsValid" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isTouched (x: System.Boolean) = "IsTouched" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDelay (x: System.Int32) = "ValidationDelay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suppressRenderingOnValidation (x: System.Boolean) = "SuppressRenderingOnValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suppressImplicitSubmission (x: System.Boolean) = "SuppressImplicitSubmission" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isValidChanged fn = (Bolero.Html.attr.callback<System.Boolean> "IsValidChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isTouchedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "IsTouchedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline errors (x: System.String[]) = "Errors" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline errorsChanged fn = (Bolero.Html.attr.callback<System.String[]> "ErrorsChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudHidden<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudHidden>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudHidden>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudHidden>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudHidden>
    static member inline breakpoint (x: MudBlazor.Breakpoint) = "Breakpoint" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline invert (x: System.Boolean) = "Invert" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isHidden (x: System.Boolean) = "IsHidden" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isHiddenChanged fn = (Bolero.Html.attr.callback<System.Boolean> "IsHiddenChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudIcon<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudIcon>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudIcon>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudIcon>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudIcon>
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline viewBox (x: System.String) = "ViewBox" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudInputControl<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudInputControl>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudInputControl>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudInputControl>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudInputControl>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputContent (x: string) = Bolero.Html.attr.fragment "InputContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputContent (node) = Bolero.Html.attr.fragment "InputContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputContent (nodes) = Bolero.Html.attr.fragment "InputContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline margin (x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Boolean) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline error (x: System.Boolean) = "Error" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline errorText (x: System.String) = "ErrorText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline variant (x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudInputLabel<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudInputLabel>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudInputLabel>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudInputLabel>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudInputLabel>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline error (x: System.Boolean) = "Error" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline variant (x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline margin (x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudLink<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudLink>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudLink>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudLink>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudLink>
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline typo (x: MudBlazor.Typo) = "Typo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline underline (x: MudBlazor.Underline) = "Underline" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudList<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudList>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudList>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudList>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudList>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline clickable (x: System.Boolean) = "Clickable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disablePadding (x: System.Boolean) = "DisablePadding" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableGutters (x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedItem (x: MudBlazor.MudListItem) = "SelectedItem" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedItemChanged fn = (Bolero.Html.attr.callback<MudBlazor.MudListItem> "SelectedItemChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudListItem<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudListItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudListItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudListItem>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudListItem>
    static member inline text (x: System.String) = "Text" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatar (x: System.String) = "Avatar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatarClass (x: System.String) = "AvatarClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableRipple (x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconColor (x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inset (x: System.Boolean) = "Inset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableGutters (x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expanded (x: System.Boolean) = "Expanded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline initiallyExpanded (x: System.Boolean) = "InitiallyExpanded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline nestedList (x: string) = Bolero.Html.attr.fragment "NestedList" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline nestedList (node) = Bolero.Html.attr.fragment "NestedList" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline nestedList (nodes) = Bolero.Html.attr.fragment "NestedList" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudListSubheader<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudListSubheader>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudListSubheader>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudListSubheader>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudListSubheader>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableGutters (x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inset (x: System.Boolean) = "Inset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudMenuItem<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudMenuItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudMenuItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudMenuItem>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudMenuItem>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline link (x: System.String) = "Link" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline forceLoad (x: System.Boolean) = "ForceLoad" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudMessageBox<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudMessageBox>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudMessageBox>

    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleContent (x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleContent (node) = Bolero.Html.attr.fragment "TitleContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleContent (nodes) = Bolero.Html.attr.fragment "TitleContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline message (x: System.String) = "Message" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline messageContent (x: string) = Bolero.Html.attr.fragment "MessageContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline messageContent (node) = Bolero.Html.attr.fragment "MessageContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline messageContent (nodes) = Bolero.Html.attr.fragment "MessageContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cancelText (x: System.String) = "CancelText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cancelButton (x: string) = Bolero.Html.attr.fragment "CancelButton" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cancelButton (node) = Bolero.Html.attr.fragment "CancelButton" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cancelButton (nodes) = Bolero.Html.attr.fragment "CancelButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noText (x: System.String) = "NoText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noButton (x: string) = Bolero.Html.attr.fragment "NoButton" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noButton (node) = Bolero.Html.attr.fragment "NoButton" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noButton (nodes) = Bolero.Html.attr.fragment "NoButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline yesText (x: System.String) = "YesText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline yesButton (x: string) = Bolero.Html.attr.fragment "YesButton" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline yesButton (node) = Bolero.Html.attr.fragment "YesButton" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline yesButton (nodes) = Bolero.Html.attr.fragment "YesButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onYes fn = (Bolero.Html.attr.callback<System.Boolean> "OnYes" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onNo fn = (Bolero.Html.attr.callback<System.Boolean> "OnNo" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCancel fn = (Bolero.Html.attr.callback<System.Boolean> "OnCancel" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isVisible (x: System.Boolean) = "IsVisible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isVisibleChanged fn = (Bolero.Html.attr.callback<System.Boolean> "IsVisibleChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudNavGroup<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudNavGroup>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudNavGroup>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudNavGroup>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudNavGroup>
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconColor (x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableRipple (x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expanded (x: System.Boolean) = "Expanded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideExpandIcon (x: System.Boolean) = "HideExpandIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxHeight (x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandIcon (x: System.String) = "ExpandIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudNavMenu<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudNavMenu>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudNavMenu>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudNavMenu>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudNavMenu>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudOverlay<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudOverlay>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudOverlay>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudOverlay>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudOverlay>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visibleChanged fn = (Bolero.Html.attr.callback<System.Boolean> "VisibleChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoClose (x: System.Boolean) = "AutoClose" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline lockScroll (x: System.Boolean) = "LockScroll" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline lockScrollClass (x: System.String) = "LockScrollClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline darkBackground (x: System.Boolean) = "DarkBackground" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline lightBackground (x: System.Boolean) = "LightBackground" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline absolute (x: System.Boolean) = "Absolute" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline zIndex (x: System.Int32) = "ZIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudPopover<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudPopover>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudPopover>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudPopover>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudPopover>
    static member inline elevation (x: System.Int32) = "Elevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline square (x: System.Boolean) = "Square" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxHeight (x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline direction (x: MudBlazor.Direction) = "Direction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offsetX (x: System.Boolean) = "OffsetX" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offsetY (x: System.Boolean) = "OffsetY" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudProgressCircular<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudProgressCircular>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudProgressCircular>

    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indeterminate (x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline min (x: System.Double) = "Min" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline max (x: System.Double) = "Max" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.Double) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline strokeWidth (x: System.Int32) = "StrokeWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline minimum (x: System.Double) = "Minimum" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maximum (x: System.Double) = "Maximum" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudProgressLinear<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudProgressLinear>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudProgressLinear>

    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indeterminate (x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline buffer (x: System.Boolean) = "Buffer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline static' (x: System.Boolean) = "Static" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline strokeWidth (x: System.Int32) = "StrokeWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline min (x: System.Double) = "Min" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline max (x: System.Double) = "Max" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.Double) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bufferValue (x: System.Double) = "BufferValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline minimum (x: System.Double) = "Minimum" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maximum (x: System.Double) = "Maximum" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudRadio<'FunBlazorGeneric, 'T> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudRadio<'T>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudRadio<'T>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudRadio<'T>>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudRadio<'T>>
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: MudBlazor.Placement) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline option (x: 'T) = "Option" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableRipple (x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudRating<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudRating>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudRating>

    static member inline ratingItemsClass (x: System.String) = "RatingItemsClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ratingItemsStyle (x: System.String) = "RatingItemsStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxValue (x: System.Int32) = "MaxValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullIcon (x: System.String) = "FullIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline emptyIcon (x: System.String) = "EmptyIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableRipple (x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedValueChanged fn = (Bolero.Html.attr.callback<System.Int32> "SelectedValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedValue (x: System.Int32) = "SelectedValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hoveredValueChanged fn = (Bolero.Html.attr.callback<System.Nullable<System.Int32>> "HoveredValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudRatingItem<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudRatingItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudRatingItem>

    static member inline itemValue (x: System.Int32) = "ItemValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableRipple (x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemClicked fn = (Bolero.Html.attr.callback<System.Int32> "ItemClicked" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemHovered fn = (Bolero.Html.attr.callback<System.Nullable<System.Int32>> "ItemHovered" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudScrollToTop<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudScrollToTop>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudScrollToTop>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudScrollToTop>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudScrollToTop>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selector (x: System.String) = "Selector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visibleCssClass (x: System.String) = "VisibleCssClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenCssClass (x: System.String) = "HiddenCssClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline topOffset (x: System.Int32) = "TopOffset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline scrollBehavior (x: MudBlazor.ScrollBehavior) = "ScrollBehavior" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onScroll fn = (Bolero.Html.attr.callback<MudBlazor.ScrollEventArgs> "OnScroll" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudSkeleton<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudSkeleton>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudSkeleton>

    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline skeletonType (x: MudBlazor.SkeletonType) = "SkeletonType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline animation (x: MudBlazor.Animation) = "Animation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudSlider<'FunBlazorGeneric, 'T> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudSlider<'T>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudSlider<'T>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudSlider<'T>>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudSlider<'T>>
    static member inline min (x: 'T) = "Min" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline max (x: 'T) = "Max" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline step (x: 'T) = "Step" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline converter (x: MudBlazor.Converter<'T>) = "Converter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'T) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline immediate (x: System.Boolean) = "Immediate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudSnackbarElement<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudSnackbarElement>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudSnackbarElement>

    static member inline snackbar (x: MudBlazor.Snackbar) = "Snackbar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudSnackbarProvider<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudSnackbarProvider>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudSnackbarProvider>

    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudSwipeArea<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudSwipeArea>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudSwipeArea>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudSwipeArea>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudSwipeArea>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSwipe (x: System.Action<MudBlazor.SwipeDirection>) = "OnSwipe" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudSimpleTable<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudSimpleTable>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudSimpleTable>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudSimpleTable>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudSimpleTable>
    static member inline elevation (x: System.Int32) = "Elevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hover (x: System.Boolean) = "Hover" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline square (x: System.Boolean) = "Square" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline striped (x: System.Boolean) = "Striped" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fixedHeader (x: System.Boolean) = "FixedHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudTableBase<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudTableBase>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudTableBase>

    static member inline elevation (x: System.Int32) = "Elevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline square (x: System.Boolean) = "Square" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hover (x: System.Boolean) = "Hover" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline striped (x: System.Boolean) = "Striped" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline breakpoint (x: MudBlazor.Breakpoint) = "Breakpoint" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fixedHeader (x: System.Boolean) = "FixedHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fixedFooter (x: System.Boolean) = "FixedFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortLabel (x: System.String) = "SortLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowUnsorted (x: System.Boolean) = "AllowUnsorted" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowsPerPage (x: System.Int32) = "RowsPerPage" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline currentPage (x: System.Int32) = "CurrentPage" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline multiSelection (x: System.Boolean) = "MultiSelection" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline toolBarContent (x: string) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline toolBarContent (node) = Bolero.Html.attr.fragment "ToolBarContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline toolBarContent (nodes) = Bolero.Html.attr.fragment "ToolBarContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loadingProgressColor (x: MudBlazor.Color) = "LoadingProgressColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerContent (x: string) = Bolero.Html.attr.fragment "HeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerContent (node) = Bolero.Html.attr.fragment "HeaderContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerContent (nodes) = Bolero.Html.attr.fragment "HeaderContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline customHeader (x: System.Boolean) = "CustomHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerClass (x: System.String) = "HeaderClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footerContent (x: string) = Bolero.Html.attr.fragment "FooterContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footerContent (node) = Bolero.Html.attr.fragment "FooterContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footerContent (nodes) = Bolero.Html.attr.fragment "FooterContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline customFooter (x: System.Boolean) = "CustomFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footerClass (x: System.String) = "FooterClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colGroup (x: string) = Bolero.Html.attr.fragment "ColGroup" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colGroup (node) = Bolero.Html.attr.fragment "ColGroup" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colGroup (nodes) = Bolero.Html.attr.fragment "ColGroup" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pagerContent (x: string) = Bolero.Html.attr.fragment "PagerContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pagerContent (node) = Bolero.Html.attr.fragment "PagerContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pagerContent (nodes) = Bolero.Html.attr.fragment "PagerContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCommitEditClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCommitEditClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCancelEditClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancelEditClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commitEditCommand (x: System.Windows.Input.ICommand) = "CommitEditCommand" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commitEditCommandParameter (x: System.Object) = "CommitEditCommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commitEditTooltip (x: System.String) = "CommitEditTooltip" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cancelEditTooltip (x: System.String) = "CancelEditTooltip" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commitEditIcon (x: System.String) = "CommitEditIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cancelEditIcon (x: System.String) = "CancelEditIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline canCancelEdit (x: System.Boolean) = "CanCancelEdit" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowEditPreview (x: System.Action<System.Object>) = "RowEditPreview" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowEditCommit (x: System.Action<System.Object>) = "RowEditCommit" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowEditCancel (x: System.Action<System.Object>) = "RowEditCancel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline totalItems (x: System.Int32) = "TotalItems" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowClass (x: System.String) = "RowClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowStyle (x: System.String) = "RowStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rightAlignSmall (x: System.Boolean) = "RightAlignSmall" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudTable<'FunBlazorGeneric, 'T> =
    inherit mudTableBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudTable<'T>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudTable<'T>>

    static member inline rowTemplate (render: 'T -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "RowTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childRowContent (render: 'T -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildRowContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowEditingTemplate (render: 'T -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "RowEditingTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline horizontalScrollbar (x: System.Boolean) = "HorizontalScrollbar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline items (x: System.Collections.Generic.IEnumerable<'T>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline filter (x: System.Func<'T, System.Boolean>) = "Filter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onRowClick fn = (Bolero.Html.attr.callback<MudBlazor.TableRowClickEventArgs<'T>> "OnRowClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowClassFunc (x: System.Func<'T, System.Int32, System.String>) = "RowClassFunc" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowStyleFunc (x: System.Func<'T, System.Int32, System.String>) = "RowStyleFunc" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedItem (x: 'T) = "SelectedItem" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedItemChanged fn = (Bolero.Html.attr.callback<'T> "SelectedItemChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedItems (x: System.Collections.Generic.HashSet<'T>) = "SelectedItems" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedItemsChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.HashSet<'T>> "SelectedItemsChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline serverData (x: System.Func<MudBlazor.TableState, System.Threading.Tasks.Task<MudBlazor.TableData<'T>>>) = "ServerData" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline elevation (x: System.Int32) = "Elevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline square (x: System.Boolean) = "Square" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hover (x: System.Boolean) = "Hover" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline striped (x: System.Boolean) = "Striped" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline breakpoint (x: MudBlazor.Breakpoint) = "Breakpoint" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fixedHeader (x: System.Boolean) = "FixedHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fixedFooter (x: System.Boolean) = "FixedFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortLabel (x: System.String) = "SortLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowUnsorted (x: System.Boolean) = "AllowUnsorted" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowsPerPage (x: System.Int32) = "RowsPerPage" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline currentPage (x: System.Int32) = "CurrentPage" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline multiSelection (x: System.Boolean) = "MultiSelection" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline toolBarContent (x: string) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline toolBarContent (node) = Bolero.Html.attr.fragment "ToolBarContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline toolBarContent (nodes) = Bolero.Html.attr.fragment "ToolBarContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loadingProgressColor (x: MudBlazor.Color) = "LoadingProgressColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerContent (x: string) = Bolero.Html.attr.fragment "HeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerContent (node) = Bolero.Html.attr.fragment "HeaderContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerContent (nodes) = Bolero.Html.attr.fragment "HeaderContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline customHeader (x: System.Boolean) = "CustomHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerClass (x: System.String) = "HeaderClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footerContent (x: string) = Bolero.Html.attr.fragment "FooterContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footerContent (node) = Bolero.Html.attr.fragment "FooterContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footerContent (nodes) = Bolero.Html.attr.fragment "FooterContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline customFooter (x: System.Boolean) = "CustomFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footerClass (x: System.String) = "FooterClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colGroup (x: string) = Bolero.Html.attr.fragment "ColGroup" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colGroup (node) = Bolero.Html.attr.fragment "ColGroup" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colGroup (nodes) = Bolero.Html.attr.fragment "ColGroup" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pagerContent (x: string) = Bolero.Html.attr.fragment "PagerContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pagerContent (node) = Bolero.Html.attr.fragment "PagerContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pagerContent (nodes) = Bolero.Html.attr.fragment "PagerContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCommitEditClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCommitEditClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCancelEditClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancelEditClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commitEditCommand (x: System.Windows.Input.ICommand) = "CommitEditCommand" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commitEditCommandParameter (x: System.Object) = "CommitEditCommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commitEditTooltip (x: System.String) = "CommitEditTooltip" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cancelEditTooltip (x: System.String) = "CancelEditTooltip" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commitEditIcon (x: System.String) = "CommitEditIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cancelEditIcon (x: System.String) = "CancelEditIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline canCancelEdit (x: System.Boolean) = "CanCancelEdit" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowEditPreview (x: System.Action<System.Object>) = "RowEditPreview" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowEditCommit (x: System.Action<System.Object>) = "RowEditCommit" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowEditCancel (x: System.Action<System.Object>) = "RowEditCancel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline totalItems (x: System.Int32) = "TotalItems" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowClass (x: System.String) = "RowClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowStyle (x: System.String) = "RowStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rightAlignSmall (x: System.Boolean) = "RightAlignSmall" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudTablePager<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudTablePager>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudTablePager>

    static member inline disableRowsPerPage (x: System.Boolean) = "DisableRowsPerPage" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSizeOptions (x: System.Int32[]) = "PageSizeOptions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline infoFormat (x: System.String) = "InfoFormat" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowsPerPageString (x: System.String) = "RowsPerPageString" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudTableSortLabel<'FunBlazorGeneric, 'T> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudTableSortLabel<'T>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudTableSortLabel<'T>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudTableSortLabel<'T>>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudTableSortLabel<'T>>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline initialDirection (x: MudBlazor.SortDirection) = "InitialDirection" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enabled (x: System.Boolean) = "Enabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortIcon (x: System.String) = "SortIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline appendIcon (x: System.Boolean) = "AppendIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortDirection (x: MudBlazor.SortDirection) = "SortDirection" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortDirectionChanged fn = (Bolero.Html.attr.callback<MudBlazor.SortDirection> "SortDirectionChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortBy (x: System.Func<'T, System.Object>) = "SortBy" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortLabel (x: System.String) = "SortLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudTd<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudTd>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudTd>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudTd>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudTd>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dataLabel (x: System.String) = "DataLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideSmall (x: System.Boolean) = "HideSmall" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudTFootRow<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudTFootRow>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudTFootRow>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudTFootRow>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudTFootRow>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCheckable (x: System.Boolean) = "IsCheckable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ignoreCheckbox (x: System.Boolean) = "IgnoreCheckbox" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ignoreEditable (x: System.Boolean) = "IgnoreEditable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onRowClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnRowClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudTh<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudTh>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudTh>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudTh>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudTh>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudTHeadRow<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudTHeadRow>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudTHeadRow>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudTHeadRow>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudTHeadRow>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCheckable (x: System.Boolean) = "IsCheckable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ignoreCheckbox (x: System.Boolean) = "IgnoreCheckbox" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ignoreEditable (x: System.Boolean) = "IgnoreEditable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onRowClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnRowClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudTr<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudTr>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudTr>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudTr>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudTr>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline item (x: System.Object) = "Item" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCheckable (x: System.Boolean) = "IsCheckable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isEditable (x: System.Boolean) = "IsEditable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isHeader (x: System.Boolean) = "IsHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isFooter (x: System.Boolean) = "IsFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCheckedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "IsCheckedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isChecked (x: System.Boolean) = "IsChecked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudTabs<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudTabs>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudTabs>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudTabs>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudTabs>
    static member inline keepPanelsAlive (x: System.Boolean) = "KeepPanelsAlive" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rounded (x: System.Boolean) = "Rounded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline border (x: System.Boolean) = "Border" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline centered (x: System.Boolean) = "Centered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideSlider (x: System.Boolean) = "HideSlider" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prevIcon (x: System.String) = "PrevIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline nextIcon (x: System.String) = "NextIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline alwaysShowScrollButtons (x: System.Boolean) = "AlwaysShowScrollButtons" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxHeight (x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline position (x: MudBlazor.Position) = "Position" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sliderColor (x: MudBlazor.Color) = "SliderColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconColor (x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline scrollIconColor (x: MudBlazor.Color) = "ScrollIconColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline elevation (x: System.Int32) = "Elevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline applyEffectsToContainer (x: System.Boolean) = "ApplyEffectsToContainer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableRipple (x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tabPanelClass (x: System.String) = "TabPanelClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline panelClass (x: System.String) = "PanelClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activePanelIndex (x: System.Int32) = "ActivePanelIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activePanelIndexChanged fn = (Bolero.Html.attr.callback<System.Int32> "ActivePanelIndexChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudTimeLine<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudTimeLine>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudTimeLine>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudTimeLine>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudTimeLine>
    static member inline rounded (x: System.Boolean) = "Rounded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline border (x: System.Boolean) = "Border" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline elevation (x: System.Int32) = "Elevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudTimeLineItem<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudTimeLineItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudTimeLineItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudTimeLineItem>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudTimeLineItem>
    static member inline elevation (x: System.Int32) = "Elevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline align (x: MudBlazor.Align) = "Align" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudTooltip<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudTooltip>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudTooltip>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudTooltip>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudTooltip>
    static member inline text (x: System.String) = "Text" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline delay (x: System.Double) = "Delay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline delayed (x: System.Double) = "Delayed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: MudBlazor.Placement) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tooltipContent (x: string) = Bolero.Html.attr.fragment "TooltipContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tooltipContent (node) = Bolero.Html.attr.fragment "TooltipContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tooltipContent (nodes) = Bolero.Html.attr.fragment "TooltipContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inline' (x: System.Boolean) = "Inline" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudTreeView<'FunBlazorGeneric, 'T> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudTreeView<'T>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudTreeView<'T>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudTreeView<'T>>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudTreeView<'T>>
    static member inline canSelect (x: System.Boolean) = "CanSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline canActivate (x: System.Boolean) = "CanActivate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandOnClick (x: System.Boolean) = "ExpandOnClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline canHover (x: System.Boolean) = "CanHover" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxHeight (x: System.String) = "MaxHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline items (x: System.Collections.Generic.HashSet<'T>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activatedValueChanged fn = (Bolero.Html.attr.callback<'T> "ActivatedValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedValuesChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.HashSet<'T>> "SelectedValuesChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (render: 'T -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline serverData (x: System.Func<'T, System.Threading.Tasks.Task<System.Collections.Generic.HashSet<'T>>>) = "ServerData" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudTreeViewItem<'FunBlazorGeneric, 'T> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudTreeViewItem<'T>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudTreeViewItem<'T>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudTreeViewItem<'T>>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudTreeViewItem<'T>>
    static member inline text (x: System.String) = "Text" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'T) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline culture (x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline textTypo (x: MudBlazor.Typo) = "TextTypo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline textClass (x: System.String) = "TextClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline endText (x: System.String) = "EndText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline endTextTypo (x: MudBlazor.Typo) = "EndTextTypo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline endTextClass (x: System.String) = "EndTextClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline content (x: string) = Bolero.Html.attr.fragment "Content" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline content (node) = Bolero.Html.attr.fragment "Content" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline content (nodes) = Bolero.Html.attr.fragment "Content" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline items (x: System.Collections.Generic.HashSet<'T>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expanded (x: System.Boolean) = "Expanded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activated (x: System.Boolean) = "Activated" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selected (x: System.Boolean) = "Selected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconColor (x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline endIcon (x: System.String) = "EndIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline endIconColor (x: MudBlazor.Color) = "EndIconColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activatedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ActivatedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "SelectedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudText<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudText>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudText>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudText>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudText>
    static member inline typo (x: MudBlazor.Typo) = "Typo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline align (x: MudBlazor.Align) = "Align" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline gutterBottom (x: System.Boolean) = "GutterBottom" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inline' (x: System.Boolean) = "Inline" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudContainer<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudContainer>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudContainer>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudContainer>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudContainer>
    static member inline fixed' (x: System.Boolean) = "Fixed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxWidth (x: MudBlazor.MaxWidth) = "MaxWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudDivider<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudDivider>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudDivider>

    static member inline absolute (x: System.Boolean) = "Absolute" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline flexItem (x: System.Boolean) = "FlexItem" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline light (x: System.Boolean) = "Light" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline vertical (x: System.Boolean) = "Vertical" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dividerType (x: MudBlazor.DividerType) = "DividerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudDrawerHeader<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudDrawerHeader>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudDrawerHeader>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudDrawerHeader>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudDrawerHeader>
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline linkToIndex (x: System.Boolean) = "LinkToIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudGrid<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudGrid>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudGrid>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudGrid>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudGrid>
    static member inline spacing (x: System.Int32) = "Spacing" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline justify (x: MudBlazor.Justify) = "Justify" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudItem<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudItem>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudItem>
    static member inline xs (x: System.Int32) = "xs" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sm (x: System.Int32) = "sm" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline md (x: System.Int32) = "md" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline lg (x: System.Int32) = "lg" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xl (x: System.Int32) = "xl" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudHighlighter<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudHighlighter>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudHighlighter>

    static member inline text (x: System.String) = "Text" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline highlightedText (x: System.String) = "HighlightedText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline caseSensitive (x: System.Boolean) = "CaseSensitive" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline untilNextBoundary (x: System.Boolean) = "UntilNextBoundary" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudMainContent<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudMainContent>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudMainContent>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudMainContent>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudMainContent>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudPaper<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudPaper>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudPaper>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudPaper>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudPaper>
    static member inline elevation (x: System.Int32) = "Elevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline square (x: System.Boolean) = "Square" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxHeight (x: System.String) = "MaxHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxWidth (x: System.String) = "MaxWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline minHeight (x: System.String) = "MinHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline minWidth (x: System.String) = "MinWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudSparkLine<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudSparkLine>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudSparkLine>

    static member inline strokeWidth (x: System.Int32) = "StrokeWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudTabPanel<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudTabPanel>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudTabPanel>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudTabPanel>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudTabPanel>
    static member inline text (x: System.String) = "Text" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline badgeData (x: System.Object) = "BadgeData" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline badgeColor (x: MudBlazor.Color) = "BadgeColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iD (x: System.Object) = "ID" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline toolTip (x: System.String) = "ToolTip" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudToolBar<'FunBlazorGeneric> =
    inherit mudComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudToolBar>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudToolBar>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudToolBar>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudToolBar>
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableGutters (x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.Object) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline userAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudDialogProvider<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<MudBlazor.MudDialogProvider>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudDialogProvider>

    static member inline noHeader (x: System.Nullable<System.Boolean>) = "NoHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closeButton (x: System.Nullable<System.Boolean>) = "CloseButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableBackdropClick (x: System.Nullable<System.Boolean>) = "DisableBackdropClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Nullable<System.Boolean>) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline position (x: System.Nullable<MudBlazor.DialogPosition>) = "Position" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxWidth (x: System.Nullable<MudBlazor.MaxWidth>) = "MaxWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type baseMudThemeProvider<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<MudBlazor.BaseMudThemeProvider>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.BaseMudThemeProvider>

    static member inline theme (x: MudBlazor.MudTheme) = "Theme" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudThemeProvider<'FunBlazorGeneric> =
    inherit baseMudThemeProvider<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<MudBlazor.MudThemeProvider>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudThemeProvider>

    static member inline theme (x: MudBlazor.MudTheme) = "Theme" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudAppBarSpacer<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<MudBlazor.MudAppBarSpacer>



                    

type breadcrumbLink<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<MudBlazor.BreadcrumbLink>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.BreadcrumbLink>

    static member inline item (x: MudBlazor.BreadcrumbItem) = "Item" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type breadcrumbSeparator<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<MudBlazor.BreadcrumbSeparator>



                    

type mudPickerContent<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<MudBlazor.MudPickerContent>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudPickerContent>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudPickerContent>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudPickerContent>
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudPickerToolbar<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<MudBlazor.MudPickerToolbar>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudPickerToolbar>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MudBlazor.MudPickerToolbar>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<MudBlazor.MudPickerToolbar>
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableToolbar (x: System.Boolean) = "DisableToolbar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline orientation (x: MudBlazor.Orientation) = "Orientation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mudSpacer<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<MudBlazor.MudSpacer>



                    

type mudToolBarSpacer<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<MudBlazor.MudToolBarSpacer>



                    

type mudTreeViewItemToggleButton<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<MudBlazor.MudTreeViewItemToggleButton>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.MudTreeViewItemToggleButton>

    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expanded (x: System.Boolean) = "Expanded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandedIcon (x: System.String) = "ExpandedIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Fun.Blazor.MudBlazor.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.MudBlazor.DslInternals


type mudInputAdornment<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<MudBlazor.Internal.MudInputAdornment>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MudBlazor.Internal.MudInputAdornment>

    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline text (x: System.String) = "Text" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline edge (x: MudBlazor.Edge) = "Edge" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline adornmentClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "AdornmentClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Fun.Blazor.MudBlazor.DslInternals.Charts

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.MudBlazor.DslInternals


type filters<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<MudBlazor.Charts.Filters>



                    
            

// =======================================================================================================================

namespace Fun.Blazor.MudBlazor

open Fun.Blazor.MudBlazor.DslInternals


type IMudComponentBaseNode = interface end
type mudComponentBase =
    class
        inherit mudComponentBase<IMudComponentBaseNode>
    end
                    

type IMudBaseButtonNode = interface end
type mudBaseButton =
    class
        inherit mudBaseButton<IMudBaseButtonNode>
    end
                    

type IMudButtonNode = interface end
type mudButton =
    class
        inherit mudButton<IMudButtonNode>
    end
                    

type IMudFabNode = interface end
type mudFab =
    class
        inherit mudFab<IMudFabNode>
    end
                    

type IMudIconButtonNode = interface end
type mudIconButton =
    class
        inherit mudIconButton<IMudIconButtonNode>
    end
                    

type IMudMenuNode = interface end
type mudMenu =
    class
        inherit mudMenu<IMudMenuNode>
    end
                    

type IMudFileUploaderNode = interface end
type mudFileUploader =
    class
        inherit mudFileUploader<IMudFileUploaderNode>
    end
                    

type IMudBaseItemsControlNode<'TChildComponent> = interface end
type mudBaseItemsControl<'TChildComponent when 'TChildComponent :> MudBlazor.MudComponentBase> =
    class
        inherit mudBaseItemsControl<IMudBaseItemsControlNode<'TChildComponent>, 'TChildComponent>
    end
                    

type IMudBaseSelectItemNode = interface end
type mudBaseSelectItem =
    class
        inherit mudBaseSelectItem<IMudBaseSelectItemNode>
    end
                    

type IMudNavLinkNode = interface end
type mudNavLink =
    class
        inherit mudNavLink<IMudNavLinkNode>
    end
                    

type IMudSelectItemNode<'T> = interface end
type mudSelectItem<'T> =
    class
        inherit mudSelectItem<IMudSelectItemNode<'T>, 'T>
    end
                    

type IMudFormComponentNode<'T, 'U> = interface end
type mudFormComponent<'T, 'U> =
    class
        inherit mudFormComponent<IMudFormComponentNode<'T, 'U>, 'T, 'U>
    end
                    

type IMudAlertNode = interface end
type mudAlert =
    class
        inherit mudAlert<IMudAlertNode>
    end
                    

type IMudAppBarNode = interface end
type mudAppBar =
    class
        inherit mudAppBar<IMudAppBarNode>
    end
                    

type IMudAvatarNode = interface end
type mudAvatar =
    class
        inherit mudAvatar<IMudAvatarNode>
    end
                    

type IMudBadgeNode = interface end
type mudBadge =
    class
        inherit mudBadge<IMudBadgeNode>
    end
                    

type IMudBreadcrumbsNode = interface end
type mudBreadcrumbs =
    class
        inherit mudBreadcrumbs<IMudBreadcrumbsNode>
    end
                    

type IMudButtonGroupNode = interface end
type mudButtonGroup =
    class
        inherit mudButtonGroup<IMudButtonGroupNode>
    end
                    

type IMudToggleIconButtonNode = interface end
type mudToggleIconButton =
    class
        inherit mudToggleIconButton<IMudToggleIconButtonNode>
    end
                    

type IMudCardNode = interface end
type mudCard =
    class
        inherit mudCard<IMudCardNode>
    end
                    

type IMudCardActionsNode = interface end
type mudCardActions =
    class
        inherit mudCardActions<IMudCardActionsNode>
    end
                    

type IMudCardContentNode = interface end
type mudCardContent =
    class
        inherit mudCardContent<IMudCardContentNode>
    end
                    

type IMudCardHeaderNode = interface end
type mudCardHeader =
    class
        inherit mudCardHeader<IMudCardHeaderNode>
    end
                    

type IMudCardMediaNode = interface end
type mudCardMedia =
    class
        inherit mudCardMedia<IMudCardMediaNode>
    end
                    

type IMudCarouselItemNode = interface end
type mudCarouselItem =
    class
        inherit mudCarouselItem<IMudCarouselItemNode>
    end
                    

type IMudChartBaseNode = interface end
type mudChartBase =
    class
        inherit mudChartBase<IMudChartBaseNode>
    end
                    

type IMudChartNode = interface end
type mudChart =
    class
        inherit mudChart<IMudChartNode>
    end
                    
            
namespace Fun.Blazor.MudBlazor.Charts

open Fun.Blazor.MudBlazor.DslInternals


type IBarNode = interface end
type bar =
    class
        inherit Charts.bar<IBarNode>
    end
                    

type IDonutNode = interface end
type donut =
    class
        inherit Charts.donut<IDonutNode>
    end
                    

type ILineNode = interface end
type line =
    class
        inherit Charts.line<ILineNode>
    end
                    

type IPieNode = interface end
type pie =
    class
        inherit Charts.pie<IPieNode>
    end
                    

type ILegendNode = interface end
type legend =
    class
        inherit Charts.legend<ILegendNode>
    end
                    
            
namespace Fun.Blazor.MudBlazor

open Fun.Blazor.MudBlazor.DslInternals


type IMudChipSetNode = interface end
type mudChipSet =
    class
        inherit mudChipSet<IMudChipSetNode>
    end
                    

type IMudChipNode = interface end
type mudChip =
    class
        inherit mudChip<IMudChipNode>
    end
                    

type IMudCollapseNode = interface end
type mudCollapse =
    class
        inherit mudCollapse<IMudCollapseNode>
    end
                    

type IMudDialogNode = interface end
type mudDialog =
    class
        inherit mudDialog<IMudDialogNode>
    end
                    

type IMudDialogInstanceNode = interface end
type mudDialogInstance =
    class
        inherit mudDialogInstance<IMudDialogInstanceNode>
    end
                    

type IMudDrawerNode = interface end
type mudDrawer =
    class
        inherit mudDrawer<IMudDrawerNode>
    end
                    

type IMudDrawerContainerNode = interface end
type mudDrawerContainer =
    class
        inherit mudDrawerContainer<IMudDrawerContainerNode>
    end
                    

type IMudLayoutNode = interface end
type mudLayout =
    class
        inherit mudLayout<IMudLayoutNode>
    end
                    

type IMudElementNode = interface end
type mudElement =
    class
        inherit mudElement<IMudElementNode>
    end
                    

type IMudExpansionPanelNode = interface end
type mudExpansionPanel =
    class
        inherit mudExpansionPanel<IMudExpansionPanelNode>
    end
                    

type IMudExpansionPanelsNode = interface end
type mudExpansionPanels =
    class
        inherit mudExpansionPanels<IMudExpansionPanelsNode>
    end
                    

type IMudFieldNode = interface end
type mudField =
    class
        inherit mudField<IMudFieldNode>
    end
                    

type IMudFocusTrapNode = interface end
type mudFocusTrap =
    class
        inherit mudFocusTrap<IMudFocusTrapNode>
    end
                    

type IMudFormNode = interface end
type mudForm =
    class
        inherit mudForm<IMudFormNode>
    end
                    

type IMudHiddenNode = interface end
type mudHidden =
    class
        inherit mudHidden<IMudHiddenNode>
    end
                    

type IMudIconNode = interface end
type mudIcon =
    class
        inherit mudIcon<IMudIconNode>
    end
                    

type IMudInputControlNode = interface end
type mudInputControl =
    class
        inherit mudInputControl<IMudInputControlNode>
    end
                    

type IMudInputLabelNode = interface end
type mudInputLabel =
    class
        inherit mudInputLabel<IMudInputLabelNode>
    end
                    

type IMudLinkNode = interface end
type mudLink =
    class
        inherit mudLink<IMudLinkNode>
    end
                    

type IMudListNode = interface end
type mudList =
    class
        inherit mudList<IMudListNode>
    end
                    

type IMudListItemNode = interface end
type mudListItem =
    class
        inherit mudListItem<IMudListItemNode>
    end
                    

type IMudListSubheaderNode = interface end
type mudListSubheader =
    class
        inherit mudListSubheader<IMudListSubheaderNode>
    end
                    

type IMudMenuItemNode = interface end
type mudMenuItem =
    class
        inherit mudMenuItem<IMudMenuItemNode>
    end
                    

type IMudMessageBoxNode = interface end
type mudMessageBox =
    class
        inherit mudMessageBox<IMudMessageBoxNode>
    end
                    

type IMudNavGroupNode = interface end
type mudNavGroup =
    class
        inherit mudNavGroup<IMudNavGroupNode>
    end
                    

type IMudNavMenuNode = interface end
type mudNavMenu =
    class
        inherit mudNavMenu<IMudNavMenuNode>
    end
                    

type IMudOverlayNode = interface end
type mudOverlay =
    class
        inherit mudOverlay<IMudOverlayNode>
    end
                    

type IMudPopoverNode = interface end
type mudPopover =
    class
        inherit mudPopover<IMudPopoverNode>
    end
                    

type IMudProgressCircularNode = interface end
type mudProgressCircular =
    class
        inherit mudProgressCircular<IMudProgressCircularNode>
    end
                    

type IMudProgressLinearNode = interface end
type mudProgressLinear =
    class
        inherit mudProgressLinear<IMudProgressLinearNode>
    end
                    

type IMudRadioNode<'T> = interface end
type mudRadio<'T> =
    class
        inherit mudRadio<IMudRadioNode<'T>, 'T>
    end
                    

type IMudRatingNode = interface end
type mudRating =
    class
        inherit mudRating<IMudRatingNode>
    end
                    

type IMudRatingItemNode = interface end
type mudRatingItem =
    class
        inherit mudRatingItem<IMudRatingItemNode>
    end
                    

type IMudScrollToTopNode = interface end
type mudScrollToTop =
    class
        inherit mudScrollToTop<IMudScrollToTopNode>
    end
                    

type IMudSkeletonNode = interface end
type mudSkeleton =
    class
        inherit mudSkeleton<IMudSkeletonNode>
    end
                    

type IMudSliderNode<'T> = interface end
type mudSlider<'T> =
    class
        inherit mudSlider<IMudSliderNode<'T>, 'T>
    end
                    

type IMudSnackbarElementNode = interface end
type mudSnackbarElement =
    class
        inherit mudSnackbarElement<IMudSnackbarElementNode>
    end
                    

type IMudSnackbarProviderNode = interface end
type mudSnackbarProvider =
    class
        inherit mudSnackbarProvider<IMudSnackbarProviderNode>
    end
                    

type IMudSwipeAreaNode = interface end
type mudSwipeArea =
    class
        inherit mudSwipeArea<IMudSwipeAreaNode>
    end
                    

type IMudSimpleTableNode = interface end
type mudSimpleTable =
    class
        inherit mudSimpleTable<IMudSimpleTableNode>
    end
                    

type IMudTableBaseNode = interface end
type mudTableBase =
    class
        inherit mudTableBase<IMudTableBaseNode>
    end
                    

type IMudTableNode<'T> = interface end
type mudTable<'T> =
    class
        inherit mudTable<IMudTableNode<'T>, 'T>
    end
                    

type IMudTablePagerNode = interface end
type mudTablePager =
    class
        inherit mudTablePager<IMudTablePagerNode>
    end
                    

type IMudTableSortLabelNode<'T> = interface end
type mudTableSortLabel<'T> =
    class
        inherit mudTableSortLabel<IMudTableSortLabelNode<'T>, 'T>
    end
                    

type IMudTdNode = interface end
type mudTd =
    class
        inherit mudTd<IMudTdNode>
    end
                    

type IMudTFootRowNode = interface end
type mudTFootRow =
    class
        inherit mudTFootRow<IMudTFootRowNode>
    end
                    

type IMudThNode = interface end
type mudTh =
    class
        inherit mudTh<IMudThNode>
    end
                    

type IMudTHeadRowNode = interface end
type mudTHeadRow =
    class
        inherit mudTHeadRow<IMudTHeadRowNode>
    end
                    

type IMudTrNode = interface end
type mudTr =
    class
        inherit mudTr<IMudTrNode>
    end
                    

type IMudTabsNode = interface end
type mudTabs =
    class
        inherit mudTabs<IMudTabsNode>
    end
                    

type IMudTimeLineNode = interface end
type mudTimeLine =
    class
        inherit mudTimeLine<IMudTimeLineNode>
    end
                    

type IMudTimeLineItemNode = interface end
type mudTimeLineItem =
    class
        inherit mudTimeLineItem<IMudTimeLineItemNode>
    end
                    

type IMudTooltipNode = interface end
type mudTooltip =
    class
        inherit mudTooltip<IMudTooltipNode>
    end
                    

type IMudTreeViewNode<'T> = interface end
type mudTreeView<'T> =
    class
        inherit mudTreeView<IMudTreeViewNode<'T>, 'T>
    end
                    

type IMudTreeViewItemNode<'T> = interface end
type mudTreeViewItem<'T> =
    class
        inherit mudTreeViewItem<IMudTreeViewItemNode<'T>, 'T>
    end
                    

type IMudTextNode = interface end
type mudText =
    class
        inherit mudText<IMudTextNode>
    end
                    

type IMudContainerNode = interface end
type mudContainer =
    class
        inherit mudContainer<IMudContainerNode>
    end
                    

type IMudDividerNode = interface end
type mudDivider =
    class
        inherit mudDivider<IMudDividerNode>
    end
                    

type IMudDrawerHeaderNode = interface end
type mudDrawerHeader =
    class
        inherit mudDrawerHeader<IMudDrawerHeaderNode>
    end
                    

type IMudGridNode = interface end
type mudGrid =
    class
        inherit mudGrid<IMudGridNode>
    end
                    

type IMudItemNode = interface end
type mudItem =
    class
        inherit mudItem<IMudItemNode>
    end
                    

type IMudHighlighterNode = interface end
type mudHighlighter =
    class
        inherit mudHighlighter<IMudHighlighterNode>
    end
                    

type IMudMainContentNode = interface end
type mudMainContent =
    class
        inherit mudMainContent<IMudMainContentNode>
    end
                    

type IMudPaperNode = interface end
type mudPaper =
    class
        inherit mudPaper<IMudPaperNode>
    end
                    

type IMudSparkLineNode = interface end
type mudSparkLine =
    class
        inherit mudSparkLine<IMudSparkLineNode>
    end
                    

type IMudTabPanelNode = interface end
type mudTabPanel =
    class
        inherit mudTabPanel<IMudTabPanelNode>
    end
                    

type IMudToolBarNode = interface end
type mudToolBar =
    class
        inherit mudToolBar<IMudToolBarNode>
    end
                    

type IMudDialogProviderNode = interface end
type mudDialogProvider =
    class
        inherit mudDialogProvider<IMudDialogProviderNode>
    end
                    

type IBaseMudThemeProviderNode = interface end
type baseMudThemeProvider =
    class
        inherit baseMudThemeProvider<IBaseMudThemeProviderNode>
    end
                    

type IMudThemeProviderNode = interface end
type mudThemeProvider =
    class
        inherit mudThemeProvider<IMudThemeProviderNode>
    end
                    

type IMudAppBarSpacerNode = interface end
type mudAppBarSpacer =
    class
        inherit mudAppBarSpacer<IMudAppBarSpacerNode>
    end
                    

type IBreadcrumbLinkNode = interface end
type breadcrumbLink =
    class
        inherit breadcrumbLink<IBreadcrumbLinkNode>
    end
                    

type IBreadcrumbSeparatorNode = interface end
type breadcrumbSeparator =
    class
        inherit breadcrumbSeparator<IBreadcrumbSeparatorNode>
    end
                    

type IMudPickerContentNode = interface end
type mudPickerContent =
    class
        inherit mudPickerContent<IMudPickerContentNode>
    end
                    

type IMudPickerToolbarNode = interface end
type mudPickerToolbar =
    class
        inherit mudPickerToolbar<IMudPickerToolbarNode>
    end
                    

type IMudSpacerNode = interface end
type mudSpacer =
    class
        inherit mudSpacer<IMudSpacerNode>
    end
                    

type IMudToolBarSpacerNode = interface end
type mudToolBarSpacer =
    class
        inherit mudToolBarSpacer<IMudToolBarSpacerNode>
    end
                    

type IMudTreeViewItemToggleButtonNode = interface end
type mudTreeViewItemToggleButton =
    class
        inherit mudTreeViewItemToggleButton<IMudTreeViewItemToggleButtonNode>
    end
                    
            
namespace Fun.Blazor.MudBlazor.Internal

open Fun.Blazor.MudBlazor.DslInternals


type IMudInputAdornmentNode = interface end
type mudInputAdornment =
    class
        inherit Internal.mudInputAdornment<IMudInputAdornmentNode>
    end
                    
            
namespace Fun.Blazor.MudBlazor.Charts

open Fun.Blazor.MudBlazor.DslInternals


type IFiltersNode = interface end
type filters =
    class
        inherit Charts.filters<IFiltersNode>
    end
                    
            
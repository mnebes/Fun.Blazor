namespace rec Microsoft.AspNetCore.Components.Authorization.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.AspNetCore.Components.Authorization.DslInternals


type AuthorizeViewCoreBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(AuthorizeViewCoreBuilder<'FunBlazorGeneric>())
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("NotAuthorized")>] member inline _.NotAuthorized ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> NodeRenderFragment) = render ==> html.renderFragment("NotAuthorized", fn)
    [<CustomOperation("Authorized")>] member inline _.Authorized ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> NodeRenderFragment) = render ==> html.renderFragment("Authorized", fn)
    [<CustomOperation("Authorizing")>] member inline _.Authorizing ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render >>> html.renderChild("Authorizing", fragment)
    [<CustomOperation("Authorizing")>] member inline _.Authorizing ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render >>> html.renderChild("Authorizing", fragment { yield! fragments })
    [<CustomOperation("Authorizing")>] member inline _.Authorizing ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render >>> html.renderChild("Authorizing", html.text x)
    [<CustomOperation("Authorizing")>] member inline _.Authorizing ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render >>> html.renderChild("Authorizing", html.text x)
    [<CustomOperation("Authorizing")>] member inline _.Authorizing ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render >>> html.renderChild("Authorizing", html.text x)
    [<CustomOperation("Resource")>] member inline _.Resource ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Resource" => x)
                

type AuthorizeViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AuthorizeViewCoreBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(AuthorizeViewBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Policy")>] member inline _.Policy ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Policy" => x)
    [<CustomOperation("Roles")>] member inline _.Roles ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Roles" => x)
                

type CascadingAuthenticationStateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithChildBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("childContent")>] member inline _.childContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render >>> html.renderChild("ChildContent", fragment)
    [<CustomOperation("childContent")>] member inline _.childContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render >>> html.renderChild("ChildContent", fragment { yield! fragments })
    [<CustomOperation("childContent")>] member inline _.childContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render >>> html.renderChild("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member inline _.childContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render >>> html.renderChild("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member inline _.childContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render >>> html.renderChild("ChildContent", html.text x)
                
            

// =======================================================================================================================

namespace Microsoft.AspNetCore.Components.Authorization

[<AutoOpen>]
module DslCE =

    open Microsoft.AspNetCore.Components.Authorization.DslInternals

    type AuthorizeViewCore'() = inherit AuthorizeViewCoreBuilder<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>()
    type AuthorizeView'() = inherit AuthorizeViewBuilder<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>()
    type CascadingAuthenticationState'() = inherit CascadingAuthenticationStateBuilder<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>()
            
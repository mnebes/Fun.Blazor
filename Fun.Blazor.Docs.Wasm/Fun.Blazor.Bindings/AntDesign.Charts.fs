namespace rec AntDesign.Charts.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.Charts.DslInternals


type ChartComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = ChartComponentBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ChartComponentBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.ChartComponentBase<'TItem, 'TConfig>>, x: 'TItem) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.ChartComponentBase<'TItem, 'TConfig>>, x: 'TConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.ChartComponentBase<'TItem, 'TConfig>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.ChartComponentBase<'TItem, 'TConfig>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.ChartComponentBase<'TItem, 'TConfig>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type ColumnLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = ColumnLineBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ColumnLineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.ColumnLine<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.ColumnLine<'TItem>>, x: AntDesign.Charts.ColumnLineConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.ColumnLine<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.ColumnLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.ColumnLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type DualLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = DualLineBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DualLineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.DualLine<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.DualLine<'TItem>>, x: AntDesign.Charts.DualLineConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.DualLine<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.DualLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.DualLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type GroupedColumnLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = GroupedColumnLineBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = GroupedColumnLineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.GroupedColumnLine<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.GroupedColumnLine<'TItem>>, x: AntDesign.Charts.GroupedColumnLineConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.GroupedColumnLine<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.GroupedColumnLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.GroupedColumnLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type StackedColumnLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = StackedColumnLineBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = StackedColumnLineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.StackedColumnLine<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.StackedColumnLine<'TItem>>, x: AntDesign.Charts.StackedColumnLineConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.StackedColumnLine<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.StackedColumnLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.StackedColumnLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type AreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = AreaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = AreaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Area<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Area<'TItem>>, x: AntDesign.Charts.AreaConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Area<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Area<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Area<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type BarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = BarBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = BarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Bar<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Bar<'TItem>>, x: AntDesign.Charts.BarConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Bar<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Bar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Bar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type BubbleBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = BubbleBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = BubbleBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Bubble<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Bubble<'TItem>>, x: AntDesign.Charts.BubbleConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Bubble<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Bubble<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Bubble<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type BulletBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = BulletBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = BulletBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Bullet<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Bullet<'TItem>>, x: AntDesign.Charts.BulletConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Bullet<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Bullet<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Bullet<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type CalendarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = CalendarBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = CalendarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Calendar<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Calendar<'TItem>>, x: AntDesign.Charts.CalendarConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Calendar<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Calendar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Calendar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type ColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = ColumnBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ColumnBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Column<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Column<'TItem>>, x: AntDesign.Charts.ColumnConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Column<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Column<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Column<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type DensityHeatmapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = DensityHeatmapBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DensityHeatmapBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.DensityHeatmap<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.DensityHeatmap<'TItem>>, x: AntDesign.Charts.DensityHeatmapConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.DensityHeatmap<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.DensityHeatmap<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.DensityHeatmap<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type DonutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = DonutBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DonutBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Donut<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Donut<'TItem>>, x: AntDesign.Charts.DonutConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Donut<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Donut<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Donut<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type FunnelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = FunnelBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = FunnelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Funnel<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Funnel<'TItem>>, x: AntDesign.Charts.FunnelConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Funnel<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Funnel<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Funnel<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type GaugeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = GaugeBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = GaugeBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Gauge<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Gauge<'TItem>>, x: AntDesign.Charts.GaugeConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Gauge<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Gauge<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Gauge<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type GroupedBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = GroupedBarBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = GroupedBarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.GroupedBar<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.GroupedBar<'TItem>>, x: AntDesign.Charts.GroupedBarConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.GroupedBar<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.GroupedBar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.GroupedBar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type GroupedColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = GroupedColumnBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = GroupedColumnBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.GroupedColumn<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.GroupedColumn<'TItem>>, x: AntDesign.Charts.GroupedColumnConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.GroupedColumn<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.GroupedColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.GroupedColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type HeatmapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = HeatmapBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = HeatmapBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Heatmap<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Heatmap<'TItem>>, x: AntDesign.Charts.HeatmapConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Heatmap<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Heatmap<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Heatmap<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type HistogramBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = HistogramBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = HistogramBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Histogram<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Histogram<'TItem>>, x: AntDesign.Charts.HistogramConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Histogram<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Histogram<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Histogram<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type LineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = LineBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = LineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Line<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Line<'TItem>>, x: AntDesign.Charts.LineConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Line<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Line<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Line<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type LiquidBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = LiquidBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = LiquidBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Liquid<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Liquid<'TItem>>, x: AntDesign.Charts.LiquidConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Liquid<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Liquid<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Liquid<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type PercentStackedAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = PercentStackedAreaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = PercentStackedAreaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.PercentStackedArea<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.PercentStackedArea<'TItem>>, x: AntDesign.Charts.PercentStackedAreaConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.PercentStackedArea<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.PercentStackedArea<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.PercentStackedArea<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type PercentStackedBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = PercentStackedBarBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = PercentStackedBarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.PercentStackedBar<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.PercentStackedBar<'TItem>>, x: AntDesign.Charts.PercentStackedBarConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.PercentStackedBar<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.PercentStackedBar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.PercentStackedBar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type PercentStackedColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = PercentStackedColumnBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = PercentStackedColumnBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.PercentStackedColumn<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.PercentStackedColumn<'TItem>>, x: AntDesign.Charts.PercentStackedColumnConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.PercentStackedColumn<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.PercentStackedColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.PercentStackedColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type PieBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = PieBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = PieBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Pie<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Pie<'TItem>>, x: AntDesign.Charts.PieConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Pie<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Pie<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Pie<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type RadarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = RadarBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = RadarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Radar<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Radar<'TItem>>, x: AntDesign.Charts.RadarConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Radar<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Radar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Radar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type RangeBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = RangeBarBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = RangeBarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.RangeBar<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.RangeBar<'TItem>>, x: AntDesign.Charts.RangeBarConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.RangeBar<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.RangeBar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.RangeBar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type RangeColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = RangeColumnBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = RangeColumnBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.RangeColumn<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.RangeColumn<'TItem>>, x: AntDesign.Charts.RangeColumnConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.RangeColumn<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.RangeColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.RangeColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type RoseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = RoseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = RoseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Rose<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Rose<'TItem>>, x: AntDesign.Charts.RoseConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Rose<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Rose<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Rose<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type ScatterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = ScatterBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ScatterBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Scatter<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Scatter<'TItem>>, x: AntDesign.Charts.ScatterConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Scatter<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Scatter<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Scatter<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type StackedAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = StackedAreaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = StackedAreaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.StackedArea<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.StackedArea<'TItem>>, x: AntDesign.Charts.StackedAreaConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.StackedArea<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.StackedArea<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.StackedArea<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type StackedBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = StackedBarBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = StackedBarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.StackedBar<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.StackedBar<'TItem>>, x: AntDesign.Charts.StackedBarConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.StackedBar<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.StackedBar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.StackedBar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type StackedColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = StackedColumnBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = StackedColumnBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.StackedColumn<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.StackedColumn<'TItem>>, x: AntDesign.Charts.StackedColumnConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.StackedColumn<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.StackedColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.StackedColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type StepLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = StepLineBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = StepLineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.StepLine<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.StepLine<'TItem>>, x: AntDesign.Charts.StepLineConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.StepLine<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.StepLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.StepLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type TreemapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TreemapBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TreemapBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Treemap<'TItem>>, x: AntDesign.Charts.ITreemapData<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Treemap<'TItem>>, x: AntDesign.Charts.TreemapConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Treemap<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Treemap<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Treemap<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type WaterfallBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = WaterfallBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = WaterfallBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Waterfall<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Waterfall<'TItem>>, x: AntDesign.Charts.WaterfallConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Waterfall<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Waterfall<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Waterfall<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type ProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = ProgressBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ProgressBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Progress<'TItem>>, x: System.Double) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Progress<'TItem>>, x: AntDesign.Charts.ProgressConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Progress<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Progress<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Progress<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type RingProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = RingProgressBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = RingProgressBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.RingProgress>, x: System.Double) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.RingProgress>, x: AntDesign.Charts.RingProgressConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.RingProgress>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.RingProgress>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.RingProgress>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type TinyAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TinyAreaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TinyAreaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.TinyArea<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.TinyArea<'TItem>>, x: AntDesign.Charts.TinyAreaConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.TinyArea<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.TinyArea<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.TinyArea<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type TinyColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TinyColumnBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TinyColumnBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.TinyColumn<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.TinyColumn<'TItem>>, x: AntDesign.Charts.TinyColumnConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.TinyColumn<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.TinyColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.TinyColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type TinyLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TinyLineBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TinyLineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.TinyLine<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.TinyLine<'TItem>>, x: AntDesign.Charts.TinyLineConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.TinyLine<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.TinyLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.TinyLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type TempBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TempBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TempBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Charts.Temp<'TItem>>, x: 'TItem) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Charts.Temp<'TItem>>, x: AntDesign.Charts.BarConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<AntDesign.Charts.Temp<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<AntDesign.Charts.Temp<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.Charts.Temp<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                
            

// =======================================================================================================================

namespace AntDesign.Charts

[<AutoOpen>]
module DslCE =

    open AntDesign.Charts.DslInternals

    type ChartComponentBase'<'TItem, 'TConfig when 'TConfig : not struct and 'TConfig : (new : unit -> 'TConfig)> = ChartComponentBaseBuilder<AntDesign.Charts.ChartComponentBase<'TItem, 'TConfig>>
    type ColumnLine'<'TItem> = ColumnLineBuilder<AntDesign.Charts.ColumnLine<'TItem>>
    type DualLine'<'TItem> = DualLineBuilder<AntDesign.Charts.DualLine<'TItem>>
    type GroupedColumnLine'<'TItem> = GroupedColumnLineBuilder<AntDesign.Charts.GroupedColumnLine<'TItem>>
    type StackedColumnLine'<'TItem> = StackedColumnLineBuilder<AntDesign.Charts.StackedColumnLine<'TItem>>
    type Area'<'TItem> = AreaBuilder<AntDesign.Charts.Area<'TItem>>
    type Bar'<'TItem> = BarBuilder<AntDesign.Charts.Bar<'TItem>>
    type Bubble'<'TItem> = BubbleBuilder<AntDesign.Charts.Bubble<'TItem>>
    type Bullet'<'TItem> = BulletBuilder<AntDesign.Charts.Bullet<'TItem>>
    type Calendar'<'TItem> = CalendarBuilder<AntDesign.Charts.Calendar<'TItem>>
    type Column'<'TItem> = ColumnBuilder<AntDesign.Charts.Column<'TItem>>
    type DensityHeatmap'<'TItem> = DensityHeatmapBuilder<AntDesign.Charts.DensityHeatmap<'TItem>>
    type Donut'<'TItem> = DonutBuilder<AntDesign.Charts.Donut<'TItem>>
    type Funnel'<'TItem> = FunnelBuilder<AntDesign.Charts.Funnel<'TItem>>
    type Gauge'<'TItem> = GaugeBuilder<AntDesign.Charts.Gauge<'TItem>>
    type GroupedBar'<'TItem> = GroupedBarBuilder<AntDesign.Charts.GroupedBar<'TItem>>
    type GroupedColumn'<'TItem> = GroupedColumnBuilder<AntDesign.Charts.GroupedColumn<'TItem>>
    type Heatmap'<'TItem> = HeatmapBuilder<AntDesign.Charts.Heatmap<'TItem>>
    type Histogram'<'TItem> = HistogramBuilder<AntDesign.Charts.Histogram<'TItem>>
    type Line'<'TItem> = LineBuilder<AntDesign.Charts.Line<'TItem>>
    type Liquid'<'TItem> = LiquidBuilder<AntDesign.Charts.Liquid<'TItem>>
    type PercentStackedArea'<'TItem> = PercentStackedAreaBuilder<AntDesign.Charts.PercentStackedArea<'TItem>>
    type PercentStackedBar'<'TItem> = PercentStackedBarBuilder<AntDesign.Charts.PercentStackedBar<'TItem>>
    type PercentStackedColumn'<'TItem> = PercentStackedColumnBuilder<AntDesign.Charts.PercentStackedColumn<'TItem>>
    type Pie'<'TItem> = PieBuilder<AntDesign.Charts.Pie<'TItem>>
    type Radar'<'TItem> = RadarBuilder<AntDesign.Charts.Radar<'TItem>>
    type RangeBar'<'TItem> = RangeBarBuilder<AntDesign.Charts.RangeBar<'TItem>>
    type RangeColumn'<'TItem> = RangeColumnBuilder<AntDesign.Charts.RangeColumn<'TItem>>
    type Rose'<'TItem> = RoseBuilder<AntDesign.Charts.Rose<'TItem>>
    type Scatter'<'TItem> = ScatterBuilder<AntDesign.Charts.Scatter<'TItem>>
    type StackedArea'<'TItem> = StackedAreaBuilder<AntDesign.Charts.StackedArea<'TItem>>
    type StackedBar'<'TItem> = StackedBarBuilder<AntDesign.Charts.StackedBar<'TItem>>
    type StackedColumn'<'TItem> = StackedColumnBuilder<AntDesign.Charts.StackedColumn<'TItem>>
    type StepLine'<'TItem> = StepLineBuilder<AntDesign.Charts.StepLine<'TItem>>
    type Treemap'<'TItem> = TreemapBuilder<AntDesign.Charts.Treemap<'TItem>>
    type Waterfall'<'TItem> = WaterfallBuilder<AntDesign.Charts.Waterfall<'TItem>>
    type Progress'<'TItem> = ProgressBuilder<AntDesign.Charts.Progress<'TItem>>
    type RingProgress' = RingProgressBuilder<AntDesign.Charts.RingProgress>
    type TinyArea'<'TItem> = TinyAreaBuilder<AntDesign.Charts.TinyArea<'TItem>>
    type TinyColumn'<'TItem> = TinyColumnBuilder<AntDesign.Charts.TinyColumn<'TItem>>
    type TinyLine'<'TItem> = TinyLineBuilder<AntDesign.Charts.TinyLine<'TItem>>
    type Temp'<'TItem> = TempBuilder<AntDesign.Charts.Temp<'TItem>>
            
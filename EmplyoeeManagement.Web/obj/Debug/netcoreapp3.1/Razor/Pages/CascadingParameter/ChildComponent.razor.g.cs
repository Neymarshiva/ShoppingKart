#pragma checksum "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\CascadingParameter\ChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01e66e3299f9379db17ee40c87f0fc047d32ff6c"
// <auto-generated/>
#pragma warning disable 1591
namespace EmplyoeeManagement.Web.Pages.CascadingParameter
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\_Imports.razor"
using EmplyoeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\_Imports.razor"
using EmplyoeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\_Imports.razor"
using HelperClass.Componet.Web.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\_Imports.razor"
using HelperClass.Componet;

#line default
#line hidden
#nullable disable
    public partial class ChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "style", (
#nullable restore
#line 1 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\CascadingParameter\ChildComponent.razor"
            ElementStyle

#line default
#line hidden
#nullable disable
            ) + ";" + (
#nullable restore
#line 1 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\CascadingParameter\ChildComponent.razor"
                           H1Border

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(2, "-Child Component ");
            __builder.AddContent(3, 
#nullable restore
#line 1 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\CascadingParameter\ChildComponent.razor"
                                                         Counter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<EmplyoeeManagement.Web.Pages.CascadingParameter.GrandChildComponent>(5);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\CascadingParameter\ChildComponent.razor"
       
    [CascadingParameter(Name = "ColorStyle")]
    public string ElementStyle { get; set; }

    [CascadingParameter(Name = "BorderStyle")]
    public string H1Border { get; set; }

    [CascadingParameter(Name = "Counter")]
    public int Counter { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

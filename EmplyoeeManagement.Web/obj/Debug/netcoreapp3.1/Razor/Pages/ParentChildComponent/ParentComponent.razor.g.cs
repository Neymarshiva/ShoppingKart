#pragma checksum "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\ParentChildComponent\ParentComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce417c5d9ab82b51089d48f4d110426e858c4356"
// <auto-generated/>
#pragma warning disable 1591
namespace EmplyoeeManagement.Web.Pages.ParentChildComponent
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/pc")]
    public partial class ParentComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ParentComponent</h3>\r\n\r\n");
            __builder.OpenComponent<EmplyoeeManagement.Web.Pages.ParentChildComponent.ChildComponent>(1);
            __builder.AddAttribute(2, "InputAttributes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.Object>>(
#nullable restore
#line 4 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\ParentChildComponent\ParentComponent.razor"
                                 attributesFromParent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Value", "Parent Componet value");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\ParentChildComponent\ParentComponent.razor"
       
     public Dictionary<string, object> attributesFromParent { get; set; } =
        new Dictionary<string, object>()
        {
            { "required", "required" },
            { "placeholder", "Parent Component Placeholder" },
            { "size", "50" },
            { "maxlength", "5" }
        };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\CascadingParameter\ParentComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57362bf21fbeed04f1ed29f40710fca9f0a82940"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Cascading")]
    public partial class ParentComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\CascadingParameter\ParentComponent.razor"
       
    public string Style { get; set; } = "color:red";
    public string BorderStyle { get; set; } = "border:1px solid red";


    public int Counter { get; set; } = 0;

    private void IncrementCounter()
    {
        Counter = Counter + 1;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

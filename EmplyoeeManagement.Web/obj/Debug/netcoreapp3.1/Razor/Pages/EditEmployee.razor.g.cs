#pragma checksum "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3baf1440f66feb2f78673fc2877361810e3f7a9"
// <auto-generated/>
#pragma warning disable 1591
namespace EmplyoeeManagement.Web.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployee/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployee")]
    public partial class EditEmployee : EditEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                  EditEmployeeModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                                                    HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ObjectGraphDataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "h3");
                __builder2.AddContent(8, 
#nullable restore
#line 9 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
         PageHeader

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\r\n    <hr>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group row");
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.AddMarkupContent(15, "<label for=\"firstName\" class=\"col-sm-2 col-form-label\">\r\n            First Name\r\n        </label>\r\n        ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col-sm-10");
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "id", "firstName");
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "placeholder", "First Name");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                                    EditEmployeeModel.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.FirstName = __value, EditEmployeeModel.FirstName))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditEmployeeModel.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __Blazor.EmplyoeeManagement.Web.Pages.EditEmployee.TypeInference.CreateValidationMessage_0(__builder2, 27, 28, 
#nullable restore
#line 19 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                                      () => EditEmployeeModel.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group row");
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.AddMarkupContent(35, "<label for=\"lastName\" class=\"col-sm-2 col-form-label\">\r\n            Last Name\r\n        </label>\r\n        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "col-sm-10");
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "id", "lastName");
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "placeholder", "Last Name");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                                    EditEmployeeModel.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.LastName = __value, EditEmployeeModel.LastName))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditEmployeeModel.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __Blazor.EmplyoeeManagement.Web.Pages.EditEmployee.TypeInference.CreateValidationMessage_1(__builder2, 47, 48, 
#nullable restore
#line 29 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                                      () => EditEmployeeModel.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group row");
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.AddMarkupContent(55, "<label for=\"email\" class=\"col-sm-2 col-form-label\">\r\n            Email\r\n        </label>\r\n        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col-sm-10");
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(59);
                __builder2.AddAttribute(60, "id", "email");
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "placeholder", "Email");
                __builder2.AddAttribute(63, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                                    EditEmployeeModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.Email = __value, EditEmployeeModel.Email))));
                __builder2.AddAttribute(65, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditEmployeeModel.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n            ");
                __Blazor.EmplyoeeManagement.Web.Pages.EditEmployee.TypeInference.CreateValidationMessage_2(__builder2, 67, 68, 
#nullable restore
#line 39 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                                      () => EditEmployeeModel.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(69, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group row");
                __builder2.AddMarkupContent(74, "\r\n        ");
                __builder2.AddMarkupContent(75, "<label for=\"email\" class=\"col-sm-2 col-form-label\">\r\n            Confirm  Email\r\n        </label>\r\n        ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "col-sm-10");
                __builder2.AddMarkupContent(78, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(79);
                __builder2.AddAttribute(80, "id", "email");
                __builder2.AddAttribute(81, "class", "form-control");
                __builder2.AddAttribute(82, "placeholder", "Email");
                __builder2.AddAttribute(83, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                                    EditEmployeeModel.ConfirmEmail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.ConfirmEmail = __value, EditEmployeeModel.ConfirmEmail))));
                __builder2.AddAttribute(85, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditEmployeeModel.ConfirmEmail));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n            ");
                __Blazor.EmplyoeeManagement.Web.Pages.EditEmployee.TypeInference.CreateValidationMessage_3(__builder2, 87, 88, 
#nullable restore
#line 49 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                                      () => EditEmployeeModel.ConfirmEmail

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(89, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n    ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "form-group row");
                __builder2.AddMarkupContent(94, "\r\n        ");
                __builder2.AddMarkupContent(95, "<label for=\"department\" class=\"col-sm-2 col-form-label\">\r\n            Department\r\n        </label>\r\n        ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "col-sm-10");
                __builder2.AddMarkupContent(98, "\r\n            ");
                __Blazor.EmplyoeeManagement.Web.Pages.EditEmployee.TypeInference.CreateCustomInputSelect_4(__builder2, 99, 100, "department", 101, "form-control", 102, 
#nullable restore
#line 57 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                                                            EditEmployeeModel.DepartmentId

#line default
#line hidden
#nullable disable
                , 103, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.DepartmentId = __value, EditEmployeeModel.DepartmentId)), 104, () => EditEmployeeModel.DepartmentId, 105, (__builder3) => {
                    __builder3.AddMarkupContent(106, "\r\n\r\n");
#nullable restore
#line 59 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                 foreach (var dept in Departments)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(107, "                    ");
                    __builder3.OpenElement(108, "option");
                    __builder3.AddAttribute(109, "value", 
#nullable restore
#line 61 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                                    dept.DepartmentId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(110, 
#nullable restore
#line 61 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                                                        dept.DepartmentName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(111, "\r\n");
#nullable restore
#line 62 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(112, "            ");
                }
                );
                __builder2.AddMarkupContent(113, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n    ");
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "form-group row");
                __builder2.AddMarkupContent(118, "\r\n        ");
                __builder2.AddMarkupContent(119, "<label for=\"gender\" class=\"col-sm-2 col-form-label\">\r\n            Department\r\n        </label>\r\n        ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "col-sm-10");
                __builder2.AddMarkupContent(122, "\r\n            ");
                __Blazor.EmplyoeeManagement.Web.Pages.EditEmployee.TypeInference.CreateCustomInputSelect_5(__builder2, 123, 124, "department", 125, "form-control", 126, 
#nullable restore
#line 71 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                                                            EditEmployeeModel.Gender

#line default
#line hidden
#nullable disable
                , 127, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.Gender = __value, EditEmployeeModel.Gender)), 128, () => EditEmployeeModel.Gender, 129, (__builder3) => {
                    __builder3.AddMarkupContent(130, "\r\n");
#nullable restore
#line 72 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                 foreach (var gender in Enum.GetValues(typeof(Gender)))
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(131, "                    ");
                    __builder3.OpenElement(132, "option");
                    __builder3.AddAttribute(133, "value", 
#nullable restore
#line 74 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                                    gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(134, 
#nullable restore
#line 74 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                                             gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(135, "\r\n");
#nullable restore
#line 75 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(136, "            ");
                }
                );
                __builder2.AddMarkupContent(137, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n    ");
                __builder2.OpenElement(140, "div");
                __builder2.AddAttribute(141, "class", "form-group row");
                __builder2.AddMarkupContent(142, "\r\n        ");
                __builder2.AddMarkupContent(143, "<label for=\"DateOfBirth\" class=\"col-sm-2 col-form-label\">\r\n            Department\r\n        </label>\r\n        ");
                __builder2.OpenElement(144, "div");
                __builder2.AddAttribute(145, "class", "col-sm-10");
                __builder2.AddMarkupContent(146, "\r\n            ");
                __Blazor.EmplyoeeManagement.Web.Pages.EditEmployee.TypeInference.CreateInputDate_6(__builder2, 147, 148, 
#nullable restore
#line 84 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                                    Employee.DateOfBirth

#line default
#line hidden
#nullable disable
                , 149, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.DateOfBirth = __value, Employee.DateOfBirth)), 150, () => Employee.DateOfBirth);
                __builder2.AddMarkupContent(151, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(153, "\r\n    ");
                __builder2.AddMarkupContent(154, "<button class=\"btn btn-primary\" type=\"submit\">Save</button>\r\n");
#nullable restore
#line 88 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
     if (EditEmployeeModel.EmplyoeeId > 0)
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(155, "        ");
                __builder2.OpenElement(156, "button");
                __builder2.AddAttribute(157, "class", "btn btn-danger");
                __builder2.AddAttribute(158, "type", "button");
                __builder2.AddAttribute(159, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                                                               Delete_Click

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(160, "\r\n            Delete\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\r\n");
#nullable restore
#line 93 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(162, "\r\n\r\n");
            __builder.OpenComponent<HelperClass.Componet.Confirm>(163);
            __builder.AddAttribute(164, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 96 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                                                        ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(165, "ConfirmationMessage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 97 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
                               $"Are you sure you want to delete \"{Employee.FirstName}\""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(166, (__value) => {
#nullable restore
#line 96 "F:\shiva\Blazor\BlazorTutorial\EmplyoeeManagement.Web\Pages\EditEmployee.razor"
               DeleteConfirmation = (HelperClass.Componet.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.EmplyoeeManagement.Web.Pages.EditEmployee
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateCustomInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::HelperClass.Componet.Web.Pages.CustomInputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateCustomInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::HelperClass.Componet.Web.Pages.CustomInputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

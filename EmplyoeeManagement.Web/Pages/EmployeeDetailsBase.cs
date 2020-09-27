using EmplyoeeManagement.Web.Services;
using EmplyoeeManagementModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmplyoeeManagement.Web.Pages
{
    public class EmployeeDetailsBase : ComponentBase
    {
        public Emplyoee Employee { get; set; } = new Emplyoee();
        protected string Coordinates { get; set; }

        protected string ButtonText { get; set; } = "Hide Footer";
        protected string CssClass { get; set; } = null;

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
        }

        protected void Button_Click()
        {
            if (ButtonText == "Hide Footer")
            {
                ButtonText = "Show Footer";
                CssClass = "HideFooter";
            }
            else
            {
                CssClass = null;
                ButtonText = "Hide Footer";
            }
        }
    }
}

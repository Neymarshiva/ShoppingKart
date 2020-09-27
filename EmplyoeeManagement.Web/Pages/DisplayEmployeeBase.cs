using EmplyoeeManagement.Web.Services;
using EmplyoeeManagementModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmplyoeeManagement.Web.Pages
{
    public class DisplayEmployeeBase: ComponentBase
    {
        [Parameter]
        public Emplyoee Employee { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; }
        protected bool IsSelected { get; set; }
        [Parameter]
        public EventCallback<bool> OnEmployeeSelection { get; set; }
        [Parameter]
        public EventCallback<int> OnEmployeeDeleted { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected HelperClass.Componet.ConfirmBase DeleteConfirmation { get; set; }

        protected void Delete_Click()
        {
            DeleteConfirmation.Show();
        }

        public async Task ConfirmDelete_Click(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await EmployeeService.DeleteEmployee(Employee.EmplyoeeId);
                await OnEmployeeDeleted.InvokeAsync(Employee.EmplyoeeId);
                //NavigationManager.NavigateTo("/", true);
            }
        }

        //protected async Task Delete_Click()
        //{
        //    await EmployeeService.DeleteEmployee(Employee.EmplyoeeId);
        //    await OnEmployeeDeleted.InvokeAsync(Employee.EmplyoeeId);
        //    //NavigationManager.NavigateTo("/", true);
        //}

        protected async Task CheckBoxChanged(ChangeEventArgs e)
        {
            IsSelected = (bool)e.Value;
            await OnEmployeeSelection.InvokeAsync(IsSelected);
        }
    }
}

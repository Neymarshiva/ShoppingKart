using EmplyoeeManagement.Web.Services;
using EmplyoeeManagementModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EmplyoeeManagement.Web.Pages
{
    public class EmplyoeeListBase:ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Emplyoee> Emplyoees { get; set; }
        public bool ShowFooter { get; set; } = true;
        protected int SelectedEmployeesCount { get; set; } = 0;
        protected override async Task OnInitializedAsync()
        {            
            Emplyoees = (await EmployeeService.GetEmployees()).ToList();
        }

        protected void EmployeeSelectionChanged(bool isSelected)
        {
            if (isSelected)
            {
                SelectedEmployeesCount++;
            }
            else
            {
                SelectedEmployeesCount--;
            }
        }
        protected async Task EmployeeDeleted()
        {
            Emplyoees = (await EmployeeService.GetEmployees()).ToList();
        }
    }

}


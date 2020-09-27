using EmplyoeeManagement.Web.Services;
using EmplyoeeManagementModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmplyoeeManagement.Web.Models;
using AutoMapper;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net;

namespace EmplyoeeManagement.Web.Pages
{
    public class EditEmployeeBase: ComponentBase
    {
        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        public Emplyoee Employee { get; set; } = new Emplyoee();

        public List<Department> Departments { get; set; } = new List<Department>();
        public EditEmployeeModel EditEmployeeModel { get; set; } = new EditEmployeeModel();

        [Inject]
        public IMapper Mapper { get; set; }

        [Parameter]
        public string Id { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected HelperClass.Componet.ConfirmBase DeleteConfirmation { get; set; }
        public string PageHeader { get; set; }

        protected async override Task OnInitializedAsync()
        {
            var authenticationState = await authenticationStateTask;
            if (!authenticationState.User.Identity.IsAuthenticated)
            {
                string returnUrl = WebUtility.UrlEncode($"/editEmployee/{Id}");
                NavigationManager.NavigateTo($"/identity/account/login?returnUrl={returnUrl}");
            }
            int.TryParse(Id, out int employeeId);

            if (employeeId != 0)
            {
                PageHeader = "Edit Employee";
                Employee = await EmployeeService.GetEmployee(int.Parse(Id));
            }
            else
            {
                PageHeader = "Create Employee";

                Employee = new Emplyoee
                {
                    DepartmentId = 1,
                    DateOfBirth = DateTime.Now,
                    PhotoPath = "images/nophoto.jpg"
                };
            }

           // Employee = await EmployeeService.GetEmployee(int.Parse(Id));
            Departments = (await DepartmentService.GetDepartments()).ToList();
            Mapper.Map(Employee, EditEmployeeModel);



            //EditEmployeeModel.EmplyoeeId = Employee.EmplyoeeId;
            //EditEmployeeModel.FirstName = Employee.FirstName;
            //EditEmployeeModel.LastName = Employee.LastName;
            //EditEmployeeModel.Email = Employee.Email;
            //EditEmployeeModel.ConfirmEmail = Employee.Email;
            //EditEmployeeModel.DateOfBirth = Employee.DateOfBirth;
            //EditEmployeeModel.Gender = Employee.Gender;
            //EditEmployeeModel.PhotoPath = Employee.PhotoPath;
            //EditEmployeeModel.DepartmentId = Employee.DepartmentId;
            //EditEmployeeModel.Department = Employee.Department;
        }

        protected async Task HandleValidSubmit()
        {
            Mapper.Map(EditEmployeeModel, Employee);

            Emplyoee result = null;

            if (Employee.EmplyoeeId != 0)
            {
                result = await EmployeeService.UpdateEmployee(Employee);
            }
            else
            {
                result = await EmployeeService.CreateEmployee(Employee);
            }
             
            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }

        protected void Delete_Click()
        {
            DeleteConfirmation.Show();
        }

        protected async Task ConfirmDelete_Click(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await EmployeeService.DeleteEmployee(Employee.EmplyoeeId);
                  NavigationManager.NavigateTo("/");
            }
        }

        //protected async Task Delete_Click()
        //{
        //    await EmployeeService.DeleteEmployee(Employee.EmplyoeeId);
        //    NavigationManager.NavigateTo("/");
        //}

    }
}

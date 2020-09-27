using EmplyoeeManagementModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmplyoeeManagement.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Emplyoee>> GetEmployees()
        {
            return await httpClient.GetJsonAsync<Emplyoee[]>("api/employees");
        }
        public async Task<Emplyoee> GetEmployee(int id)
        {
            return await httpClient.GetJsonAsync<Emplyoee>($"api/employees/{id}");
        }
        public async Task<Emplyoee> UpdateEmployee(Emplyoee updatedEmployee)
        {
            return await httpClient.PutJsonAsync<Emplyoee>("api/employees", updatedEmployee);
        }

        public async Task<Emplyoee> CreateEmployee(Emplyoee newEmployee)
        {
            try
            {
                return await httpClient.PostJsonAsync<Emplyoee>("api/employees", newEmployee);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
        public async Task DeleteEmployee(int id)
        {
            try
            {
                await httpClient.DeleteAsync($"api/employees/{id}");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}

using EmplyoeeManagementModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmplyoeeManagement.Web.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly HttpClient httpClient;

        public DepartmentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Department> GetDepartment(int id)
        {
            return await httpClient.GetJsonAsync<Department>($"api/Departments/{id}");
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            try
            {
                return await httpClient.GetJsonAsync<Department[]>("api/Departments");
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}

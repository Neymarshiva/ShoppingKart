using EmplyoeeManagementModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmplyoeeManagement.Web.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Emplyoee>> GetEmployees();
        Task<Emplyoee> GetEmployee(int id);
        Task<Emplyoee> UpdateEmployee(Emplyoee updatedEmployee);
        Task<Emplyoee> CreateEmployee(Emplyoee newEmployee);
        Task DeleteEmployee(int id);
    }
}

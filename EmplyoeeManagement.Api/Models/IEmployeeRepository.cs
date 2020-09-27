using EmplyoeeManagementModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmplyoeeManagement.Api.Models
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Emplyoee>> GetEmployees();
        Task<Emplyoee> GetEmployee(int employeeId);
        Task<Emplyoee> AddEmployee(Emplyoee employee);
        Task<Emplyoee> UpdateEmployee(Emplyoee employee);
        Task<Emplyoee> DeleteEmployee(int employeeId);
        Task<Emplyoee> GetEmployeeByEmail(string email);
        Task<IEnumerable<Emplyoee>> Search(string name, Gender? gender);
    }
}

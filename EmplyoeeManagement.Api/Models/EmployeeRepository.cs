using EmplyoeeManagement.Api.Dapper;
using EmplyoeeManagementModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace EmplyoeeManagement.Api.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext appDbContext;
        private readonly IDataBaseConnection _db;

        public EmployeeRepository(AppDbContext appDbContext, IDataBaseConnection db)
        {
            this.appDbContext = appDbContext;
            this._db = db;
        }

        public async Task<IEnumerable<Emplyoee>> GetEmployees()
        {
            try
            {
                var resutlt = await _db.Connection.QueryAsync<Emplyoee>("GetEmplyoeeDetails");
                return resutlt;
               // return await appDbContext.Employees.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Emplyoee> GetEmployeeByEmail(string email)
        {
            return await appDbContext.Employees
                .FirstOrDefaultAsync(e => e.Email == email);
        }
        public async Task<Emplyoee> GetEmployee(int employeeId)
        {

            try
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@Id", employeeId);
                var result = await _db.Connection.QueryFirstOrDefaultAsync<Emplyoee>("GetEmplyoeeById", parameter, commandType: CommandType.StoredProcedure);

                return await appDbContext.Employees
                .Include(e => e.Department)
                .FirstOrDefaultAsync(e => e.EmplyoeeId == employeeId);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public async Task<Emplyoee> AddEmployee(Emplyoee employee)
        {
            var result = await appDbContext.Employees.AddAsync(employee);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Emplyoee> UpdateEmployee(Emplyoee employee)
        {
            var result = await appDbContext.Employees
                .FirstOrDefaultAsync(e => e.EmplyoeeId == employee.EmplyoeeId);

            if (result != null)
            {
                result.FirstName = employee.FirstName;
                result.LastName = employee.LastName;
                result.Email = employee.Email;
                result.DateOfBirth = employee.DateOfBirth;
                result.Gender = employee.Gender;
                result.DepartmentId = employee.DepartmentId;
                result.PhotoPath = employee.PhotoPath;

                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public async Task<Emplyoee> DeleteEmployee(int employeeId)
        {
            var result = await appDbContext.Employees
                .FirstOrDefaultAsync(e => e.EmplyoeeId == employeeId);
            if (result != null)
            {
                appDbContext.Employees.Remove(result);
                await appDbContext.SaveChangesAsync();
            }
            return null;
        }
        public async Task<IEnumerable<Emplyoee>> Search(string name, Gender? gender)
        {
            IQueryable<Emplyoee> query = appDbContext.Employees;

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.FirstName.Contains(name)
                            || e.LastName.Contains(name));
            }

            if (gender != null)
            {
                query = query.Where(e => e.Gender == gender);
            }

            return await query.ToListAsync();
        }

    }
}

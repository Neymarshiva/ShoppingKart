using EmplyoeeManagement.Api.Dapper;
using EmplyoeeManagementModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;

namespace EmplyoeeManagement.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext appDbContext;        
        public DepartmentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;          
        }

        public async Task<Department> GetDepartment(int departmentId)
        {
            try
            {

                return await appDbContext.Departments
               .FirstOrDefaultAsync(d => d.DepartmentId == departmentId);
            }
            catch(Exception ex)
            {
                throw;
            }
                     
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await appDbContext.Departments.ToListAsync();
        }
    }
}

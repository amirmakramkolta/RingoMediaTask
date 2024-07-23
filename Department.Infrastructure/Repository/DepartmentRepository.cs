using Department.Core.Interfaces;
using Department.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Infrastructure.Repository
{
    public class DepartmentRepository(DepartmentDbContext context) : IDepartmentRepository
    {

        public async Task AddDepartment(string Name, string logo, int? parentDepartment, CancellationToken token)
        {
            var NewDepartment = Core.DomainEnties.Department.CreateNewDepartment(Name, logo, parentDepartment);
            await context.Departments.AddAsync(NewDepartment, token);
        }

        public async Task<int> Commit(CancellationToken token)
        {
            return await context.SaveChangesAsync(token);
        }

        public async Task<Core.DomainEnties.Department> GetDepartmentByid(int Id, CancellationToken token)
        {
            var department = await context.Departments.FirstAsync(x=>x.Id == Id, token);
            return department;
        }

        public async Task<List<Core.DomainEnties.Department>> GetDepartments(int? parentDepartmentId, CancellationToken token)
        {
            var list = context.Departments.Where(x => x.ParentDpartmentId == parentDepartmentId);
            return await list.ToListAsync(token);
        }
    }
}

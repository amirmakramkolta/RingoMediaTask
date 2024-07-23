using Department.Core.Interfaces;
using Department.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Infrastructure.Repository
{
    public class DepartmentRepository(DepartmentDbContext context) : IDepartmentRepository
    {

        public Task AddDepartment(Core.DomainEnties.Department NewDepartment, int parentDepartment)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Commit()
        {
            return await context.SaveChangesAsync();
        }

        public Task<List<Core.DomainEnties.Department>> GetDepartments(int parentDepartmentId)
        {
            throw new NotImplementedException();
        }
    }
}

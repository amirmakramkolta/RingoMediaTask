using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Core.Interfaces
{
    public interface IDepartmentRepository
    {
        public Task AddDepartment(string Name, string logo, int? parentDepartment, CancellationToken token);
        public Task<List<Department.Core.DomainEnties.Department>> GetDepartments(int? parentDepartmentId, CancellationToken token);
        public Task<int> Commit(CancellationToken token);
    }
}

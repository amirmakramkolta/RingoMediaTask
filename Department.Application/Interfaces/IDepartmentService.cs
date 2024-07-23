using Department.Application.Dtos.Request;
using Department.Application.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Application.Interfaces
{
    public interface IDepartmentService
    {
        public Task AddDepartment(AddDepartmentDto NewDepartment, CancellationToken token);
        public Task<List<GetDepartmentDto>> GetDepartments(int? ParentId, CancellationToken token);
    }
}

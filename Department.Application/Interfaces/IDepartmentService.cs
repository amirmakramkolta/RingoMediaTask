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
        public void AddDepartment(AddDepartmentDto NewDepartment);
        public List<DepartmentResultDto> GetDepartments(int ParentId);
    }
}

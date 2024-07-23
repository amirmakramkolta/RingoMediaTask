using Department.Application.Dtos.Request;
using Department.Application.Dtos.Response;
using Department.Application.Interfaces;
using Department.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Application.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public void AddDepartment(AddDepartmentDto NewDepartment)
        {
            throw new NotImplementedException();
        }

        public List<DepartmentResultDto> GetDepartments(int ParentId)
        {
            throw new NotImplementedException();
        }
    }
}

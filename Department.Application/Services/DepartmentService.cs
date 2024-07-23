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

        public async Task AddDepartment(AddDepartmentDto NewDepartment, CancellationToken token)
        {
            if (NewDepartment.ParentDepartmentId == 0) NewDepartment.ParentDepartmentId = null;
            await _departmentRepository.AddDepartment(NewDepartment.DepartmentName, NewDepartment.logo, NewDepartment.ParentDepartmentId, token);
            await _departmentRepository.Commit(token);
        }

        public async Task<List<GetDepartmentDto>> GetDepartments(int? ParentId, CancellationToken token)
        {
            if(ParentId == 0) ParentId = null;
            var list = await _departmentRepository.GetDepartments(ParentId, token);
            return list.Select(x =>
            {
                return new GetDepartmentDto()
                {
                    Id = x.Id,
                    DepartmentName = x.Name,
                    Logo = x.Logo,
                    ParentDepartmentId = x.ParentDpartmentId,
                    CreatedAt = x.CreatedAt,
                };
            }).ToList();

        }

        public async Task<GetDepartmentDto> GetDepartment(int Id, CancellationToken token)
        {
            var departmentResult = await _departmentRepository.GetDepartmentByid(Id, token);
            if (departmentResult == null) return null;
            var department = new GetDepartmentDto()
            {
                Id = departmentResult.Id,
                DepartmentName = departmentResult.Name,
                Logo = departmentResult.Logo,
                CreatedAt = departmentResult.CreatedAt,
            };

            return department;
        }

    }
}

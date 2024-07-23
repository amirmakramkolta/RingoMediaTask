using Department.Application.Dtos.Request;
using Department.Application.Dtos.Response;
using Department.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Department.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController(IDepartmentService service) : ControllerBase
    {
        [HttpPost]
        [Route(nameof(AddDepartment))]
        public async Task AddDepartment([FromBody]AddDepartmentDto dto, CancellationToken token)
        {
            await service.AddDepartment(dto, token);
        }
        [HttpGet]
        [Route(nameof(GetDepartments))]
        public async Task<List<GetDepartmentDto>> GetDepartments(int? ParentDepartment, CancellationToken token)
        {
            return await service.GetDepartments(ParentDepartment, token);
        }
    }
}

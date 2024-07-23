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
        public async Task<IActionResult> AddDepartment([FromBody]AddDepartmentDto dto, CancellationToken token)
        {
            await service.AddDepartment(dto, token);
            return Created();
        }
        [HttpGet]
        [Route(nameof(GetDepartments))]
        public async Task<IActionResult> GetDepartments(int? ParentDepartment, CancellationToken token)
        {
            var result = await service.GetDepartments(ParentDepartment, token);
            return Ok(result);
        }
        [HttpGet]
        [Route(nameof(GetDepartment))]
        public async Task<IActionResult> GetDepartment(int Id, CancellationToken token)
        {
            var result = await service.GetDepartment(Id, token);
            if (result == null) return NotFound();
            return Ok(result);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Notification.Application.Dtos.Request;
using Notification.Application.Dtos.Response;
using Notification.Application.Interfaces;

namespace Notification.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController(INotificationService service) : ControllerBase
    {
        [HttpPost]
        [Route(nameof(AddEmail))]
        public async Task<IActionResult> AddEmail([FromBody] AddEmailDto dto, CancellationToken token)
        {
            await service.AddEmail(dto, token);
            return Created();
        }
        [HttpGet]
        [Route(nameof(GetEmails))]
        public async Task<IActionResult> GetEmails(CancellationToken token)
        {
            var result = await service.GetEmails(token);
            return Ok(result);
        }
    }
}

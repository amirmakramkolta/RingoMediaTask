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
        public async Task AddEmail([FromBody] AddEmailDto dto, CancellationToken token)
        {
            await service.AddEmail(dto, token);
        }
        [HttpGet]
        [Route(nameof(GetEmails))]
        public async Task<List<GetEmailDto>> GetEmails()
        {
            return await service.GetEmails();
        }
    }
}

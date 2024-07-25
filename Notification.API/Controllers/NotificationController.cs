using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Notification.Application.Dtos.Request;
using Notification.Application.Dtos.Response;
using Notification.Application.Interfaces;

namespace Notification.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController(INotificationService service,IEmailSenderService emailService, IBackgroundJobClient backgroundService) : ControllerBase
    {
        [HttpPost]
        [Route(nameof(AddEmail))]
        public async Task<IActionResult> AddEmail([FromBody] AddEmailDto dto, CancellationToken token)
        {
            if(dto.SentAt < DateTime.Now)
            {
                return BadRequest("You should have the time in the future");
            }
            var timeDiffer = (dto.SentAt - DateTime.Now);
            backgroundService.Schedule(() => emailService.sendEmail(dto.Email), timeDiffer);
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

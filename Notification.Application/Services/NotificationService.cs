using Notification.Application.Dtos.Request;
using Notification.Application.Dtos.Response;
using Notification.Application.Interfaces;
using Notification.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Application.Services
{
    public class NotificationService(INotificationRepository notificationRepository) : INotificationService
    {
        public async Task AddEmail(AddEmailDto NewEmail, CancellationToken token = default)
        {
            await notificationRepository.AddNotification(NewEmail.Email, NewEmail.SentAt, token);
            await notificationRepository.Commit(token);
        }

        public async Task<List<GetEmailDto>> GetEmails(CancellationToken token = default)
        {
            var list = await notificationRepository.GetAllNotification(token);
            return list.Select(x =>
            {

                return new GetEmailDto()
                {
                    Email = x.Email,
                    SentAt = x.SentAt,
                    CreatedAt = x.CreatedAt,
                };
            }).ToList();
        }
    }
}

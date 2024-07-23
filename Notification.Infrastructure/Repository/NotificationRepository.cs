using Microsoft.EntityFrameworkCore;
using Notification.Core.DomainEntities;
using Notification.Core.Interfaces;
using Notification.Infrastructure.Peristence;

namespace Notification.Infrastructure.Repository
{
    public class NotificationRepository(NotifictionDbContext context) : INotificationRepository
    {
        public async Task<int> Commit(CancellationToken token) => await context.SaveChangesAsync(token);

        public async Task AddNotification(string Email, DateTime SentAt, CancellationToken token)
        {
            var NewEmail = EmailNotification.CreateNotification(Email, SentAt);
            await context.EmailNotifications.AddAsync(NewEmail, token);
        }

        public async Task<List<EmailNotification>> GetAllNotification(CancellationToken token)
        {
            return await context.EmailNotifications.ToListAsync(token);
        }
    }
}

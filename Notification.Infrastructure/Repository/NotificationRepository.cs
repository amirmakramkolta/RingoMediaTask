using Microsoft.EntityFrameworkCore;
using Notification.Core.DomainEntities;
using Notification.Core.Interfaces;
using Notification.Infrastructure.Peristence;

namespace Notification.Infrastructure.Repository
{
    public class NotificationRepository(NotifictionDbContext context) : INotificationRepository
    {
        public async Task<int> Commit() => await context.SaveChangesAsync();

        public async Task AddNotification(EmailNotification notification)
        {
            await context.EmailNotifications.AddAsync(notification);
        }

        public async Task<List<EmailNotification>> GetAllNotification()
        {
            return await context.EmailNotifications.ToListAsync();
        }
    }
}

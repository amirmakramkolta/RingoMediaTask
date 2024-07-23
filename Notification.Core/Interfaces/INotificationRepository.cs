using Notification.Core.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Core.Interfaces
{
    public interface INotificationRepository
    {
        public Task AddNotification(EmailNotification notification);
        public Task<List<EmailNotification>> GetAllNotification();
        public Task<int> Commit();

    }
}

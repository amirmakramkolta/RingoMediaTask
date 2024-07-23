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
        public Task AddNotification(string Email, DateTime SentAt, CancellationToken token);
        public Task<List<EmailNotification>> GetAllNotification(CancellationToken token);
        public Task<int> Commit(CancellationToken token);

    }
}

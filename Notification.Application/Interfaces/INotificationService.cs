using Notification.Application.Dtos.Request;
using Notification.Application.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Application.Interfaces
{
    public interface INotificationService
    {
        public Task AddEmail(AddEmailDto NewEmail, CancellationToken token = default);
        public Task<List<GetEmailDto>> GetEmails(CancellationToken token = default);
    }
}

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
        
    }
}

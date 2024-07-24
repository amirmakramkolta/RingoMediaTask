using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Application.Interfaces
{
    public interface IEmailSenderService
    {
        public Task sendEmail(string emailTo);
    }
}

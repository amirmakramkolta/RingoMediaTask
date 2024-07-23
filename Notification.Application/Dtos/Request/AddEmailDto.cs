using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Application.Dtos.Request
{
    public class AddEmailDto
    {
        public string Email { get; set; }
        public DateTime SentAt { get; set; }
    }
}

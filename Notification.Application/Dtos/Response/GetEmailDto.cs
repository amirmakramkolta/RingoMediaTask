using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Application.Dtos.Response
{
    public class GetEmailDto
    {
        public string Email { get; set; }
        public DateTime SentAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

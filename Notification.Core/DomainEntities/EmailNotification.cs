using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Core.DomainEntities
{
    public class EmailNotification
    {
        private EmailNotification()
        {

        }
        public int Id { get; private set; }
        public string Email { get; private set; }
        public DateTime SentAt { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public static EmailNotification CreateNotification(string Email, DateTime SentAt)
        {
            var NewNotification = new EmailNotification()
            {
                Email = Email,
                SentAt = SentAt,
                CreatedAt = DateTime.Now
            };
            return NewNotification;
        }

    }
}

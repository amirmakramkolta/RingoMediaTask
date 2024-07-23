using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notification.Core.DomainEntities;

namespace Notification.Infrastructure.EntityConfigration
{
    public class EmailNotificationEntityConfigration : IEntityTypeConfiguration<EmailNotification>
    {
        public void Configure(EntityTypeBuilder<EmailNotification> builder)
        {
            builder.HasKey(e=>e.Id);
        }
    }
}

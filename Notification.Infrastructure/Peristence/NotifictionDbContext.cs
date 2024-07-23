using Microsoft.EntityFrameworkCore;
using Notification.Core.DomainEntities;
using System.Reflection;

namespace Notification.Infrastructure.Peristence
{
    public class NotifictionDbContext : DbContext
    {
        public NotifictionDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<EmailNotification> EmailNotifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}

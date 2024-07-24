using Microsoft.EntityFrameworkCore;
using Notification.API.Regisiters.Interfaces;
using Notification.Application.Interfaces;
using Notification.Application.Services;
using Notification.Core.Interfaces;
using Notification.Infrastructure.Peristence;
using Notification.Infrastructure.Repository;

namespace Notification.API.Regisiters.Builder
{
    public class DbBuilderRegister : IWebApplicationBuilderRegister
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<NotifictionDbContext>(options =>
                {
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
                });
            builder.Services.AddScoped<INotificationRepository,NotificationRepository>();
            builder.Services.AddScoped<INotificationService, NotificationService>();
            builder.Services.AddScoped<IEmailSenderService, EmailSenderService>();
        }
    }
}

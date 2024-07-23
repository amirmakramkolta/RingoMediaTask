﻿using Microsoft.EntityFrameworkCore;
using Notification.API.Regisiters.Interfaces;
using Notification.Infrastructure.Peristence;

namespace Notification.API.Regisiters.App
{
    public class MvcAppRegister : IWebApplicationRegister
    {
        public void RegisterPipelineComponents(WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            using var scope = app.Services.CreateScope();
            var Services = scope.ServiceProvider;
            var NotificationContext = Services.GetRequiredService<NotifictionDbContext>();
            NotificationContext.Database.Migrate();
        }
    }
}

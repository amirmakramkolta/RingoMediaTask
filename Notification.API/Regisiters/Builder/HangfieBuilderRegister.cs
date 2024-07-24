using Hangfire;
using Microsoft.Extensions.Configuration;
using Notification.API.Regisiters.Interfaces;

namespace Notification.API.Regisiters.Builder
{
    public class HangfieBuilderRegister : IWebApplicationBuilderRegister
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddHangfire((provider, configuration) =>
            {
                configuration
                .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UseSqlServerStorage(builder.Configuration.GetConnectionString("HangfireConnection"));
            });
            
            builder.Services.AddHangfireServer();
        }
    }
}

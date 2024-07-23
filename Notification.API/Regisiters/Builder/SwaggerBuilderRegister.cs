using Notification.API.Regisiters.Interfaces;

namespace Notification.API.Regisiters.Builder
{
    public class SwaggerBuilderRegister : IWebApplicationBuilderRegister
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();
        }
    }
}

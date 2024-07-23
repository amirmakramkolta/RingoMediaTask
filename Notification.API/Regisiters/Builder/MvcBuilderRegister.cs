using Notification.API.Regisiters.Interfaces;

namespace Notification.API.Regisiters.Builder
{
    public class MvcBuilderRegister : IWebApplicationBuilderRegister
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                    policy =>
                    {
                        policy.WithOrigins("http://localhost:4200")
                                            .AllowAnyHeader()
                                            .AllowAnyMethod();
                    });
            });
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
        }
    }
}

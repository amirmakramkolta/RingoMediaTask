using Department.API.Regisiters.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Department.API.Regisiters.Builder
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

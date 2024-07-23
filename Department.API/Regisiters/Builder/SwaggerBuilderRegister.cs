using Department.API.Regisiters.Interfaces;

namespace Department.API.Regisiters.Builder
{
    public class SwaggerBuilderRegister : IWebApplicationBuilderRegister
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();
        }
    }
}

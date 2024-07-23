using Department.API.Regisiters.Interfaces;

namespace Department.API.Regisiters.Builder
{
    public class MvcBuilderRegister : IWebApplicationBuilderRegister
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
        }
    }
}

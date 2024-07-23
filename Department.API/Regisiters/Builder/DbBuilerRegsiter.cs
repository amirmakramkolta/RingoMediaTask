using Department.API.Regisiters.Interfaces;
using Department.Application.Interfaces;
using Department.Application.Services;
using Department.Core.Interfaces;
using Department.Infrastructure.Persistence;
using Department.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace Department.API.Regisiters.Builder
{
    public class DbBuilerRegsiter : IWebApplicationBuilderRegister
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<DepartmentDbContext>(options =>
                {
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
                });
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            builder.Services.AddScoped<IDepartmentService, DepartmentService>();
        }
    }
}

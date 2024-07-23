using Department.API.Regisiters.Interfaces;
using Department.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Department.API.Regisiters.App
{
    public class MvcAppRegister : IWebApplicationRegister
    {
        public void RegisterPipelineComponents(WebApplication app)
        {
            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseCors(MyAllowSpecificOrigins);

            app.MapControllers();

            using var scope = app.Services.CreateScope();
            var Services = scope.ServiceProvider;
            var DepartmentContext = Services.GetRequiredService<DepartmentDbContext>();
            DepartmentContext.Database.Migrate();
        }
    }
}

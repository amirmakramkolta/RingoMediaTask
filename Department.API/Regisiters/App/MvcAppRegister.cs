using Department.API.Regisiters.Interfaces;

namespace Department.API.Regisiters.App
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
        }
    }
}

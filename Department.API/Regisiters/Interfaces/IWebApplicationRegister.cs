namespace Department.API.Regisiters.Interfaces
{
    public interface IWebApplicationRegister : IRegister
    {
        public void RegisterPipelineComponents(WebApplication app);
    }
}

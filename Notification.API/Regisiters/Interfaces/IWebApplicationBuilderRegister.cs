namespace Notification.API.Regisiters.Interfaces
{
    public interface IWebApplicationBuilderRegister : IRegister
    {
        public void RegisterServices(WebApplicationBuilder builder);
    }
}

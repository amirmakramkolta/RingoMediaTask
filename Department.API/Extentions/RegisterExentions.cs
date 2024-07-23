using Department.API.Regisiters.Interfaces;

namespace Department.API.Extentions
{
    public static class RegisterExentions
    {
        public static void RegisterServices(this WebApplicationBuilder builder, Type scanningType)
        {
            var registrars = GetRegistrers<IWebApplicationBuilderRegister>(scanningType);

            foreach (var registrar in registrars)
            {
                registrar.RegisterServices(builder);
            }
        }

        public static void RegisterPipelineComponents(this WebApplication app, Type scanningType)
        {
            var registrars = GetRegistrers<IWebApplicationRegister>(scanningType);
            foreach (var registrar in registrars)
            {
                registrar.RegisterPipelineComponents(app);
            }
        }

        private static IEnumerable<T> GetRegistrers<T>(Type scanningType) where T : IRegister
        {
            return scanningType.Assembly.GetTypes()
                .Where(t => t.IsAssignableTo(typeof(T)) && !t.IsAbstract && !t.IsInterface)
                .Select(Activator.CreateInstance)
                .Cast<T>();
        }
    }
}

using blue_agenda_api.CrossCutting.IoC;

namespace blue_agenda_api.Configuration
{
    public static class DependencyInjectonConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentException(null, nameof(services));
            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}

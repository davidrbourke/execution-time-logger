using Microsoft.Extensions.DependencyInjection;

namespace ExecutionTimeLogger.Infrastructure
{
    public static class IoCExtensions
    {
        public static void RegisterIoCServices(this IServiceCollection services)
        {
            // services.AddTransient<IRepository<User>, UserRepository>();
        }
    }
}
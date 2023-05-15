using ASC.Application.Sprockets.Common;
using ASC.Infrastructure.DataAccess.Common;
using ASC.Infrastructure.DataAccess.Sprockets;
using Microsoft.Extensions.DependencyInjection;

namespace ASC.Infrastructure.Modules
{
    public static class Dependencies
    {
        public static void Register(this IServiceCollection services)
        {
            services.AddTransient<ISprocketService, SprocketService>();
            services.AddTransient<ISprocketRepository, SprocketRepository>();
            services.AddSingleton<ApplicationContext>();
        }
    }
}

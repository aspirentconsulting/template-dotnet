using ASC.Application.Sprockets.Common;
using Microsoft.Extensions.DependencyInjection;

namespace ASC.Infrastructure.Modules
{
    public static class Dependencies
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ISprocketService, SprocketService>();
        }
    }
}

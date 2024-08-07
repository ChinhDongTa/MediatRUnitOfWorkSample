using Microsoft.Extensions.DependencyInjection;

namespace DongTa.DataAccessMediatR {

    public static class Dependencies {

        public static IServiceCollection RegisterMediatR(this IServiceCollection services)
        {
            return services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Dependencies).Assembly));
        }
    }
}
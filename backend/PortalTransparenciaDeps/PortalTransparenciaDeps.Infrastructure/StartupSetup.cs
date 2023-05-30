using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PortalTransparenciaDeps.Infrastructure.Data;
using PortalTransparenciaDeps.Infrastructure.Identity;
using PortalTransparenciaDeps.SharedKernel.Util;

namespace PortalTransparenciaDeps.Infrastructure
{
    public static class StartupSetup
    {
        public static void AddDbContext(this IServiceCollection services) =>
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(AmbienteUtil.GetValue("POSTGRES_CONNECTION"))); // will be created in web project root

        public static void ConfigureJwt(this IServiceCollection services) => JwtStartupSetup.RegisterJWT(services);
    }
}

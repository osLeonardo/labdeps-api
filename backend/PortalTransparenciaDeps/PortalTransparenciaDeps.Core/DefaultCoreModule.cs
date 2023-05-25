using Autofac;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.Core.Services;

namespace PortalTransparenciaDeps.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PerfilMetricaService>()
                .As<IPerfilMetricaService>().InstancePerLifetimeScope();

            builder.RegisterType<PerfilService>()
                .As<IPerfilService>().InstancePerLifetimeScope();
        }
    }
}

using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.SharedKernel;

namespace PortalTransparenciaDeps.Core.Entities.PerfilAggregate.Events
{
    public class PerfilInativadoEvent : BaseDomainEvent
    {
        public PerfilInativadoEvent(Perfil perfil)
        {
            Perfil = perfil;
        }

        public Perfil Perfil { get; set; }
    }
}

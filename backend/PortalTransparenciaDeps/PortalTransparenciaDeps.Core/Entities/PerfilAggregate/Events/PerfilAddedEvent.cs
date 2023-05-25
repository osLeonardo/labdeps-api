using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.SharedKernel;

namespace PortalTransparenciaDeps.Core.Entities.PerfilAggregate.Events
{
    public class PerfilAddedEvent : BaseDomainEvent
    {
        public PerfilAddedEvent(Perfil perfil)
        {
            Perfil = perfil;
        }

        public Perfil Perfil { get; set; }

    }
}

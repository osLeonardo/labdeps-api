using Ardalis.GuardClauses;
using MediatR;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate.Events;
using PortalTransparenciaDeps.Core.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Entities.PerfilMetricaAggregate.Handlers
{
    public class PerfilAddedNotificationHandler : INotificationHandler<PerfilAddedEvent>
    {
        private readonly IPerfilMetricaService _perfilMetricaService;

        public PerfilAddedNotificationHandler(IPerfilMetricaService perfilMetricaService)
        {
            _perfilMetricaService = perfilMetricaService;
        }

        public async Task Handle(PerfilAddedEvent notification, CancellationToken cancellationToken)
        {
            Guard.Against.Null(notification, nameof(notification));
            await _perfilMetricaService.AdicionarPerfilMetricaPorPerfilAsync(notification.Perfil);
        }
    }
}

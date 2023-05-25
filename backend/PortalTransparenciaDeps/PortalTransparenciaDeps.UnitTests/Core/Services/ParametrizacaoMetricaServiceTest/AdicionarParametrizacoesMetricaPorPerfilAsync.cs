//using PortalTransparenciaDeps.Core.MetricaAggregate;
//using PortalTransparenciaDeps.Core.MetricaAggregate.Specifications;
//using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
//using PortalTransparenciaDeps.Core.Services;
//using PortalTransparenciaDeps.SharedKernel.Interfaces;
//using Moq;
//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Xunit;

//namespace PortalTransparenciaDeps.UnitTests.Core.Services.ParametrizacaoMetricaServiceTest
//{
//    public class AdicionarParametrizacoesMetricaPorPerfilAsync
//    {
//        private readonly Mock<IRepository<ParametrizacaoMetrica>> _mockRepository;
//        private readonly Mock<IRepository<Metrica>> _mockMetricaRepository;

//        public AdicionarParametrizacoesMetricaPorPerfilAsync()
//        {
//            _mockRepository = new Mock<IRepository<ParametrizacaoMetrica>>();
//            _mockMetricaRepository = new Mock<IRepository<Metrica>>();
//        }

//        [Fact]
//        public async Task CreatesNewParametrizacaoGivenPerfil()
//        {
//            var parametrizacaoService = new ParametrizacaoMetricaService(null, _mockMetricaRepository.Object, _mockRepository.Object);

//            var metrica = Metrica.Factory.NovaMetrica("Teste");
//            metrica.Id = 1;
//            var listMetrica = new List<Metrica> { metrica };

//            _mockMetricaRepository.Setup(r => r.ListAsync(It.IsAny<MetricasPorAtivoSpec>(), default)).ReturnsAsync(listMetrica);

//            var perfil = Perfil.Factory.NovoPerfil("Teste perfil", 1);
//            perfil.Id = 2;

//            await parametrizacaoService.AdicionarParametrizacoesMetricaPorPerfilAsync(perfil);

//            _mockRepository.Verify(x => x.AddAsync(It.Is<ParametrizacaoMetrica>(x => x.MetricaId == 1 && x.PerfilId == 2), default), Times.Once);
//        }

//        [Fact]
//        public async Task ThrowsGivenNullPerfil()
//        {
//            var parametrizacaoService = new ParametrizacaoMetricaService(null, null, null);

//            var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await parametrizacaoService.AdicionarParametrizacoesMetricaPorPerfilAsync(null));
//            Assert.Equal("perfil", ex.ParamName);
//        }
//    }
//}

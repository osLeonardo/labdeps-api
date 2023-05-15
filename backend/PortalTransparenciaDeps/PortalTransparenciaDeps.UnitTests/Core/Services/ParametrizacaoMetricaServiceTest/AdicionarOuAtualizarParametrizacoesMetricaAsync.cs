//using PortalTransparenciaDeps.Core.DTO;
//using PortalTransparenciaDeps.Core.Services;
//using PortalTransparenciaDeps.SharedKernel.Interfaces;
//using Moq;
//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Xunit;

//namespace PortalTransparenciaDeps.UnitTests.Core.Services.ParametrizacaoMetricaServiceTest
//{
//    public class AdicionarOuAtualizarParametrizacoesMetricaAsync
//    {
//        private readonly Mock<IRepository<ParametrizacaoMetrica>> _mockRepository;

//        public AdicionarOuAtualizarParametrizacoesMetricaAsync()
//        {
//            _mockRepository = new Mock<IRepository<ParametrizacaoMetrica>>();
//        }

//        [Fact]
//        public async Task CreatesNewParametrizacaoMetrica()
//        {
//            var parametrizacaoService = new ParametrizacaoMetricaService(null, null, _mockRepository.Object);

//            var cadastroParametrizacaoMetrica = new CadastroParametrizacaoMetricaDto { Id = null, PerfilId = 1, MetricaId = 2 };
//            var listParametrizacao = new List<CadastroParametrizacaoMetricaDto> { cadastroParametrizacaoMetrica };

//            await parametrizacaoService.AdicionarOuAtualizarParametrizacoesMetricaAsync(listParametrizacao);

//            _mockRepository.Verify(x => x.AddAsync(It.Is<ParametrizacaoMetrica>(x => x.MetricaId == 2 && x.PerfilId == 1), default), Times.Once);
//            _mockRepository.Verify(x => x.UpdateAsync(It.IsAny<ParametrizacaoMetrica>(), default), Times.Never);
//        }

//        [Fact]
//        public async Task CreatesAndUpdatesParametrizacaoMetrica()
//        {
//            var parametrizacaoService = new ParametrizacaoMetricaService(null, null, _mockRepository.Object);

//            var id = Guid.NewGuid();
//            var cadastroParametrizacaoMetrica = new CadastroParametrizacaoMetricaDto { Id = null, PerfilId = 1, MetricaId = 2, Idade = 30 };
//            var parametrizacaoMetrica = new ParametrizacaoMetrica(2, 1, 50, null, null, null, null);
//            parametrizacaoMetrica.Id = id;

//            var atualizarParametrizacaoMetrica = new CadastroParametrizacaoMetricaDto { Id = id, PerfilId = 1, MetricaId = 2, Idade = 60 };
//            var listParametrizacao = new List<CadastroParametrizacaoMetricaDto> { cadastroParametrizacaoMetrica, atualizarParametrizacaoMetrica };
//            _mockRepository.Setup(x => x.GetByIdAsync(It.Is<Guid>(x => x == id), default)).ReturnsAsync(parametrizacaoMetrica);

//            await parametrizacaoService.AdicionarOuAtualizarParametrizacoesMetricaAsync(listParametrizacao);

//            _mockRepository.Verify(x => x.AddAsync(It.Is<ParametrizacaoMetrica>(x => x.MetricaId == 2 && x.PerfilId == 1 && x.Idade == 30), default), Times.Once);
//            _mockRepository.Verify(x => x.UpdateAsync(It.Is<ParametrizacaoMetrica>(x => x.MetricaId == 2 && x.PerfilId == 1 && x.Id == id), default), Times.Once);
//        }

//        [Fact]
//        public async Task UpdatesParametrizacaoMetrica()
//        {
//            var parametrizacaoService = new ParametrizacaoMetricaService(null, null, _mockRepository.Object);

//            var id = Guid.NewGuid();
//            var atualizarParametrizacaoMetrica = new CadastroParametrizacaoMetricaDto { Id = id, PerfilId = 1, MetricaId = 2, Idade = 60 };
//            var listParametrizacao = new List<CadastroParametrizacaoMetricaDto> { atualizarParametrizacaoMetrica };

//            var parametrizacaoMetrica = new ParametrizacaoMetrica(2, 1, 50, null, null, null, null);
//            parametrizacaoMetrica.Id = id;
//            _mockRepository.Setup(x => x.GetByIdAsync(It.Is<Guid>(x => x == id), default)).ReturnsAsync(parametrizacaoMetrica);

//            await parametrizacaoService.AdicionarOuAtualizarParametrizacoesMetricaAsync(listParametrizacao);

//            _mockRepository.Verify(x => x.AddAsync(It.IsAny<ParametrizacaoMetrica>(), default), Times.Never);
//            _mockRepository.Verify(x => x.UpdateAsync(It.Is<ParametrizacaoMetrica>(x => x.MetricaId == 2 && x.PerfilId == 1 && x.Id == id), default), Times.Once);
//        }
//    }
//}

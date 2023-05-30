using Moq;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate.Events;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate.Specifications;
using PortalTransparenciaDeps.Core.Services;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace PortalTransparenciaDeps.UnitTests.Core.Services.PerfilServiceTest
{
    public class CreatePerfil
    {
        private string _testName = "Conservador + 1";

        private readonly Mock<IRepository<Perfil>> _mockPerfilRepository;

        public CreatePerfil()
        {
            _mockPerfilRepository = new Mock<IRepository<Perfil>>();
        }

        [Fact]
        public async Task CreatesNewPerfil()
        {
            var perfilService = new PerfilService(_mockPerfilRepository.Object);

            _mockPerfilRepository.Setup(x => x.ListAsync(It.IsAny<PerfisComOrdemMaiorOuIgualSpec>(), default))
                .ReturnsAsync(GetPerfis());

            var test = await perfilService.CreatPerfilAsync(_testName, 1);

            _mockPerfilRepository.Verify(x => x.AddAsync(It.Is<Perfil>(x => x.Nome == _testName), default), Times.Once);
        }

        [Fact]
        public async Task ThrowsGivenNullName()
        {
            var perfilService = new PerfilService(null);

            var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await perfilService.CreatPerfilAsync(null, 1));
            Assert.Equal("nome", ex.ParamName);
        }

        [Fact]
        public async Task ThrowsGivenWhitespaceName()
        {
            var perfilService = new PerfilService(null);

            var ex = await Assert.ThrowsAsync<ArgumentException>(async () => await perfilService.CreatPerfilAsync("  ", 1));
            Assert.Equal("nome", ex.ParamName);
        }

        [Fact]
        public async Task RaisesPerfilAddedEvent()
        {
            var perfilService = new PerfilService(_mockPerfilRepository.Object);

            _mockPerfilRepository.Setup(x => x.ListAsync(It.IsAny<PerfisComOrdemMaiorOuIgualSpec>(), default))
                .ReturnsAsync(GetPerfis());

            var test = await perfilService.CreatPerfilAsync(_testName, 1);

            Assert.Single(test.Events);
            Assert.IsType<PerfilAddedEvent>(test.Events.First());
        }

        [Fact]
        public async Task CreatesNewPerfilComOrdenacao()
        {
            var perfilService = new PerfilService(_mockPerfilRepository.Object);

            _mockPerfilRepository.Setup(x => x.ListAsync(It.IsAny<PerfisComOrdemMaiorOuIgualSpec>(), default))
                .ReturnsAsync(GetPerfis().Where(x => x.Ordem >= 2).ToList());

            var test = await perfilService.CreatPerfilAsync(_testName, 2);

            _mockPerfilRepository.Verify(x => x.UpdateAsync(It.IsAny<Perfil>(), default), Times.Exactly(2));
            _mockPerfilRepository.Verify(x => x.AddAsync(It.Is<Perfil>(x => x.Nome == _testName), default), Times.Once);
        }

        private List<Perfil> GetPerfis()
        {
            return new List<Perfil>
            {
                Perfil.Factory.NovoPerfil("Conservador", 1),
                Perfil.Factory.NovoPerfil("Moderado", 2),
                Perfil.Factory.NovoPerfil("Agressivo", 3)
            };
        }
    }
}

using Moq;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate.Events;
using PortalTransparenciaDeps.Core.Services;
using PortalTransparenciaDeps.SharedKernel.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace PortalTransparenciaDeps.UnitTests.Core.Services.PerfilServiceTest
{
    public class UpdatePerfil
    {
        private string _testName = "test perfil name";
        private string _oldName = "Old name";

        public UpdatePerfil()
        {
        }

        [Fact]
        public async Task UpdatesMetricaName()
        {
            var repo = new Mock<IRepository<Perfil>>();
            var perfilService = new PerfilService(repo.Object);

            repo.Setup(r => r.GetByIdAsync(It.IsAny<int>(), default))
                .ReturnsAsync(GetPerfil());

            var test = await perfilService.UpdatePerfilAsync(1, _testName, true);

            repo.Verify(x => x.UpdateAsync(It.Is<Perfil>(x => x.Nome == _testName), default), Times.Once);
            Assert.NotNull(test);
            Assert.Equal(_testName, test.Nome);
        }

        [Fact]
        public async Task ShouldNotCallUpdateWhenNothingChanged()
        {
            var repo = new Mock<IRepository<Perfil>>();
            var perfilService = new PerfilService(repo.Object);

            repo.Setup(r => r.GetByIdAsync(It.IsAny<int>(), default))
                .ReturnsAsync(GetPerfil());

            var test = await perfilService.UpdatePerfilAsync(1, _oldName, true);

            repo.Verify(x => x.UpdateAsync(It.Is<Perfil>(x => x.Nome == _oldName), default), Times.Never);
            Assert.Null(test);
        }

        [Fact]
        public async Task ThrowsGivenNullName()
        {
            var perfilService = new PerfilService(null);

            var ex = await Assert.ThrowsAsync<ArgumentNullException>(async () => await perfilService.UpdatePerfilAsync(1, null, true));
            Assert.Equal("nome", ex.ParamName);
        }

        [Fact]
        public async Task ThrowsGivenWhitespaceName()
        {
            var perfilService = new PerfilService(null);

            var ex = await Assert.ThrowsAsync<ArgumentException>(async () => await perfilService.UpdatePerfilAsync(1, "    ", true));
            Assert.Equal("nome", ex.ParamName);
        }

        [Fact]
        public async Task RaisesMetricaAddedEvent()
        {
            var repo = new Mock<IRepository<Perfil>>();
            var perfilService = new PerfilService(repo.Object);

            repo.Setup(r => r.GetByIdAsync(It.IsAny<int>(), default))
                .ReturnsAsync(GetPerfil());

            var test = await perfilService.UpdatePerfilAsync(1, _testName, false);

            Assert.NotNull(test);
            Assert.Single(test.Events);
            Assert.IsType<PerfilInativadoEvent>(test.Events.First());
            Assert.Equal(_testName, test.Nome);
            Assert.False(test.Ativo);
        }

        private Perfil GetPerfil()
        {
            return Perfil.Factory.NovoPerfil(_oldName, 1);
        }
    }
}

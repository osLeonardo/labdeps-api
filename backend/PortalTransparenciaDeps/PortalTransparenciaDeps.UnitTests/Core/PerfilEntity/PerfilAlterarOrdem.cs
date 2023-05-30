using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using System;
using Xunit;

namespace PortalTransparenciaDeps.UnitTests.Core.Entities.PerfilEntity
{
    public class PerfilAlterarOrdem
    {
        private string _testName = "test name";

        private Perfil CreatePerfil()
        {
            return Perfil.Factory.NovoPerfil(_testName, 1);
        }

        [Fact]
        public void SetsNewOrdem()
        {
            var perfil = CreatePerfil();
            perfil.AlterarOrdem(5);

            Assert.Equal(5, perfil.Ordem);
        }

        [Fact]
        public void ThrowsExceptionGivenZeroOrdem()
        {
            var perfil = CreatePerfil();

            Action action = () => perfil.AlterarOrdem(0);

            var ex = Assert.Throws<ArgumentException>(action);
            Assert.Equal("ordem", ex.ParamName);
        }
    }
}

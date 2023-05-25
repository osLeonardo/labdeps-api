using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using System;
using Xunit;

namespace PortalTransparenciaDeps.UnitTests.Core.Entities.PerfilEntity
{
    public class PerfilConstructor
    {
        private string _testName = "test name";
        private Perfil _testPerfil = null;

        private Perfil CreatePerfil()
        {
            return Perfil.Factory.NovoPerfil(_testName, 1);
        }

        [Fact]
        public void InitializesNameAndAtivo()
        {
            _testPerfil = CreatePerfil();

            Assert.Equal(_testName, _testPerfil.Nome);
            Assert.Equal(1, _testPerfil.Ordem);
            Assert.True(_testPerfil.Ativo);
        }

        [Fact]
        public void ThrowsExceptionGivenNullName()
        {
            Action action = () => Perfil.Factory.NovoPerfil(null, 1);

            var ex = Assert.Throws<ArgumentNullException>(action);
            Assert.Equal("nome", ex.ParamName);
        }

        [Fact]
        public void ThrowsExceptionGivenZeroOrdem()
        {
            Action action = () => Perfil.Factory.NovoPerfil(_testName, 0);

            var ex = Assert.Throws<ArgumentException>(action);
            Assert.Equal("ordem", ex.ParamName);
        }
    }
}

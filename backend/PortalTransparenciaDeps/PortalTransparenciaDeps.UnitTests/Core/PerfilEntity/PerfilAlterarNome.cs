using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using System;
using Xunit;

namespace PortalTransparenciaDeps.UnitTests.Core.Entities.PerfilEntity
{
    public class PerfilAlterarNome
    {
        private string _testName = "test name";
        private string _newName = "new name";

        private Perfil CreatePerfil()
        {
            return Perfil.Factory.NovoPerfil(_testName, 1);
        }

        [Fact]
        public void SetsNewName()
        {
            var perfil = CreatePerfil();
            perfil.AlterarNome(_newName);

            Assert.Equal(_newName, perfil.Nome);
        }

        [Fact]
        public void ThrowsExceptionGivenNullName()
        {
            var perfil = CreatePerfil();

            Action action = () => perfil.AlterarNome(null);

            var ex = Assert.Throws<ArgumentNullException>(action);
            Assert.Equal("novoNome", ex.ParamName);
        }
    }
}

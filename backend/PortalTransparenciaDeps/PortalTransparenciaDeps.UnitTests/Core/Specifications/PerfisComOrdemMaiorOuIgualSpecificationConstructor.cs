using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate.Specifications;
using System.Collections.Generic;
using Xunit;

namespace PortalTransparenciaDeps.UnitTests.Core.Specifications
{
    public class PerfisComOrdemMaiorOuIgualSpecificationConstructor
    {
        [Fact]
        public void FilterCollectionToOnlyReturnPerfisComOrdemMaiorOuIgual()
        {
            var name = "teste";
            var perfil1 = Perfil.Factory.NovoPerfil(name, 1);
            var perfil2 = Perfil.Factory.NovoPerfil(name, 2);
            var perfil3 = Perfil.Factory.NovoPerfil(name, 3);

            var items = new List<Perfil>() { perfil1, perfil2, perfil3 };

            var spec = new PerfisComOrdemMaiorOuIgualSpec(2);
            var filteredList = spec.Evaluate(items);

            Assert.Contains(perfil2, filteredList);
            Assert.Contains(perfil3, filteredList);
            Assert.DoesNotContain(perfil1, filteredList);
        }
    }
}

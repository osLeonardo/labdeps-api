using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate.Specifications;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PortalTransparenciaDeps.UnitTests.Core.Specifications
{
    public class PerfisOrdenadosSpecificationConstructor
    {
        [Fact]
        public void OrderCollectionByOrdem()
        {
            var name = "teste";
            var perfil1 = Perfil.Factory.NovoPerfil(name, 2);
            var perfil2 = Perfil.Factory.NovoPerfil(name, 3);
            var perfil3 = Perfil.Factory.NovoPerfil(name, 1);

            var items = new List<Perfil>() { perfil1, perfil2, perfil3 };

            var spec = new PerfisOrdenadosSpec();
            var filteredList = spec.Evaluate(items);

            Assert.Equal(perfil3, filteredList.First());
            Assert.Equal(perfil2, filteredList.Last());
        }
    }
}

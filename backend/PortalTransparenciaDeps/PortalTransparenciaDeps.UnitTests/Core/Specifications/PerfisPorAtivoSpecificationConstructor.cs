using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate.Specifications;
using System.Collections.Generic;
using Xunit;

namespace PortalTransparenciaDeps.UnitTests.Core.Specifications
{
    public class PerfisPorAtivoSpecificationConstructor
    {
        [Fact]
        public void FilterCollectionToOnlyReturnPerfisAtivas()
        {
            var name = "teste";
            var perfil1 = Perfil.Factory.NovoPerfil(name, 1);
            var perfil2 = Perfil.Factory.NovoPerfil(name, 2);
            var perfil3 = Perfil.Factory.NovoPerfil(name, 3);
            var perfil4 = Perfil.Factory.NovoPerfil("Inativa1", 4);
            var perfil5 = Perfil.Factory.NovoPerfil("Inativa2", 5);

            perfil4.Inativar();
            perfil5.Inativar();

            var items = new List<Perfil>() { perfil1, perfil2, perfil3, perfil4, perfil5 };

            var spec = new PerfisPorAtivoSpec(true, string.Empty);
            var filteredList = spec.Evaluate(items);

            Assert.Contains(perfil1, filteredList);
            Assert.Contains(perfil2, filteredList);
            Assert.Contains(perfil3, filteredList);
            Assert.DoesNotContain(perfil4, filteredList);
            Assert.DoesNotContain(perfil5, filteredList);
        }

        [Fact]
        public void FilterCollectionToOnlyReturnMetricasInativas()
        {
            var name = "teste";
            var perfil1 = Perfil.Factory.NovoPerfil(name, 1);
            var perfil2 = Perfil.Factory.NovoPerfil(name, 2);
            var perfil3 = Perfil.Factory.NovoPerfil(name, 3);
            var perfil4 = Perfil.Factory.NovoPerfil("Inativa1", 4);
            var perfil5 = Perfil.Factory.NovoPerfil("Inativa2", 5);

            perfil4.Inativar();
            perfil5.Inativar();

            var items = new List<Perfil>() { perfil1, perfil2, perfil3, perfil4, perfil5 };

            var spec = new PerfisPorAtivoSpec(false, string.Empty);
            var filteredList = spec.Evaluate(items);

            Assert.Contains(perfil4, filteredList);
            Assert.Contains(perfil5, filteredList);
            Assert.DoesNotContain(perfil1, filteredList);
            Assert.DoesNotContain(perfil2, filteredList);
            Assert.DoesNotContain(perfil3, filteredList);
        }

        [Fact]
        public void FilterCollectionByName()
        {
            var name = "teste";
            var perfil1 = Perfil.Factory.NovoPerfil(name, 1);
            var perfil2 = Perfil.Factory.NovoPerfil(name, 2);
            var perfil3 = Perfil.Factory.NovoPerfil(name, 3);
            var perfil4 = Perfil.Factory.NovoPerfil("Inativa1", 4);
            var perfil5 = Perfil.Factory.NovoPerfil(name, 5);

            perfil4.Inativar();
            perfil5.Inativar();

            var items = new List<Perfil>() { perfil1, perfil2, perfil3, perfil4, perfil5 };

            var spec = new PerfisPorAtivoSpec(false, "Ina");
            var filteredList = spec.Evaluate(items);

            Assert.Contains(perfil4, filteredList);
            Assert.DoesNotContain(perfil5, filteredList);
        }

        [Fact]
        public void FilterCollectionByNameInsensitive()
        {
            var name = "teste";
            var perfil1 = Perfil.Factory.NovoPerfil(name, 1);
            var perfil2 = Perfil.Factory.NovoPerfil(name, 2);
            var perfil3 = Perfil.Factory.NovoPerfil(name, 3);
            var perfil4 = Perfil.Factory.NovoPerfil("Inativa1", 4);
            var perfil5 = Perfil.Factory.NovoPerfil(name, 5);

            perfil4.Inativar();
            perfil5.Inativar();

            var items = new List<Perfil>() { perfil1, perfil2, perfil3, perfil4, perfil5 };

            var spec = new PerfisPorAtivoSpec(false, "INATI");
            var filteredList = spec.Evaluate(items);

            Assert.Contains(perfil4, filteredList);
            Assert.DoesNotContain(perfil5, filteredList);
        }
    }
}

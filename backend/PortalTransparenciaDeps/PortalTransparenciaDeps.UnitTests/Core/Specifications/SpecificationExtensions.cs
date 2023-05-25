//using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
//using PortalTransparenciaDeps.Core.Specification;
//using Ardalis.Specification;
//using System.Collections.Generic;
//using Xunit;

//namespace PortalTransparenciaDeps.UnitTests.Core.Specifications
//{
//    public class SpecificationExtensions
//    {
//        internal class SimplePagedSpecification : Specification<Metrica>
//        {
//            public SimplePagedSpecification(int page, int size)
//            {
//                Query.AplicarPaginacao(page, size);
//            }
//        }

//        //internal class SimpleOrderedSpecification : Specification<Metrica>
//        //{
//        //    public SimpleOrderedSpecification(string field, string order)
//        //    {
//        //        Query.OrderBy(field, order);
//        //    }
//        //}

//        [Fact]
//        public void Pagination()
//        {
//            var name = "teste";
//            var metrica1 = Perfil.Factory.NovoPerfil(name, 1);
//            var metrica2 = Perfil.Factory.NovoPerfil(name, 2);
//            var metrica3 = Perfil.Factory.NovoPerfil(name);
//            var metrica4 = Perfil.Factory.NovoPerfil(name);
//            var metrica5 = Perfil.Factory.NovoPerfil(name);

//            var items = new List<Metrica>() { metrica1, metrica2, metrica3, metrica4, metrica5 };

//            var spec = new SimplePagedSpecification(1, 2);
//            var filteredList = spec.Evaluate(items);

//            Assert.Contains(metrica1, filteredList);
//            Assert.Contains(metrica2, filteredList);
//            Assert.DoesNotContain(metrica3, filteredList);
//            Assert.DoesNotContain(metrica4, filteredList);
//            Assert.DoesNotContain(metrica5, filteredList);
//        }

//        [Fact]
//        public void PaginationPage2()
//        {
//            var name = "teste";
//            var metrica1 = Metrica.Factory.NovaMetrica(name);
//            var metrica2 = Metrica.Factory.NovaMetrica(name);
//            var metrica3 = Metrica.Factory.NovaMetrica(name);
//            var metrica4 = Metrica.Factory.NovaMetrica(name);
//            var metrica5 = Metrica.Factory.NovaMetrica(name);

//            var items = new List<Metrica>() { metrica1, metrica2, metrica3, metrica4, metrica5 };

//            var spec = new SimplePagedSpecification(2, 2);
//            var filteredList = spec.Evaluate(items);

//            Assert.DoesNotContain(metrica1, filteredList);
//            Assert.DoesNotContain(metrica2, filteredList);
//            Assert.Contains(metrica3, filteredList);
//            Assert.Contains(metrica4, filteredList);
//            Assert.DoesNotContain(metrica5, filteredList);
//        }

//        [Fact]
//        public void PaginationPage3()
//        {
//            var name = "teste";
//            var metrica1 = Metrica.Factory.NovaMetrica(name);
//            var metrica2 = Metrica.Factory.NovaMetrica(name);
//            var metrica3 = Metrica.Factory.NovaMetrica(name);
//            var metrica4 = Metrica.Factory.NovaMetrica(name);
//            var metrica5 = Metrica.Factory.NovaMetrica(name);

//            var items = new List<Metrica>() { metrica1, metrica2, metrica3, metrica4, metrica5 };

//            var spec = new SimplePagedSpecification(3, 2);
//            var filteredList = spec.Evaluate(items);

//            Assert.DoesNotContain(metrica1, filteredList);
//            Assert.DoesNotContain(metrica2, filteredList);
//            Assert.DoesNotContain(metrica3, filteredList);
//            Assert.DoesNotContain(metrica4, filteredList);
//            Assert.Contains(metrica5, filteredList);
//        }

//        //[Fact]
//        //public void OrderByAsc()
//        //{
//        //    var metrica1 = Metrica.Factory.NovaMetrica("F");
//        //    var metrica2 = Metrica.Factory.NovaMetrica("B");
//        //    var metrica3 = Metrica.Factory.NovaMetrica("A");
//        //    var metrica4 = Metrica.Factory.NovaMetrica("G");
//        //    var metrica5 = Metrica.Factory.NovaMetrica("X");

//        //    var items = new List<Metrica>() { metrica1, metrica2, metrica3, metrica4, metrica5 };

//        //    var spec = new SimpleOrderedSpecification("nome", "asc");
//        //    var filteredList = spec.Evaluate(items);

//        //    Assert.Equal(metrica3, filteredList.ElementAt(0));
//        //    Assert.Equal(metrica2, filteredList.ElementAt(1));
//        //    Assert.Equal(metrica1, filteredList.ElementAt(2));
//        //    Assert.Equal(metrica4, filteredList.ElementAt(3));
//        //    Assert.Equal(metrica5, filteredList.ElementAt(4));
//        //}

//        //[Fact]
//        //public void OrderByDesc()
//        //{
//        //    var metrica1 = Metrica.Factory.NovaMetrica("F");
//        //    var metrica2 = Metrica.Factory.NovaMetrica("B");
//        //    var metrica3 = Metrica.Factory.NovaMetrica("A");
//        //    var metrica4 = Metrica.Factory.NovaMetrica("G");
//        //    var metrica5 = Metrica.Factory.NovaMetrica("X");

//        //    var items = new List<Metrica>() { metrica1, metrica2, metrica3, metrica4, metrica5 };

//        //    var spec = new SimpleOrderedSpecification("nome", "desc");
//        //    var filteredList = spec.Evaluate(items);

//        //    Assert.Equal(metrica3, filteredList.ElementAt(4));
//        //    Assert.Equal(metrica2, filteredList.ElementAt(3));
//        //    Assert.Equal(metrica1, filteredList.ElementAt(2));
//        //    Assert.Equal(metrica4, filteredList.ElementAt(1));
//        //    Assert.Equal(metrica5, filteredList.ElementAt(0));

//        //}
//    }
//}

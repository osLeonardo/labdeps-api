//using PortalTransparenciaDeps.Core.MetricaAggregate;
//using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
//using System;
//using Xunit;

//namespace PortalTransparenciaDeps.UnitTests.Core.ParametrizacaoMetricaEntity
//{
//    public class ParametrizacaoMetricaConstructor
//    {
//        private const int _testMetricaId = 1;
//        private const int _testPerfilId = 2;
//        private const int _testIdade = 150;
//        private const decimal _testValor = 1500m;
//        private const decimal _testPercentual = 25.5m;
//        private const decimal _testMultiplicador = 0.55m;
//        private const decimal _testDivisor = 1.5m;


//        private ParametrizacaoMetrica CreateParametrizacao()
//        {
//            return new ParametrizacaoMetrica(_testMetricaId, _testPerfilId, _testIdade, _testPercentual, _testMultiplicador, _testValor, _testDivisor);
//        }

//        [Fact]
//        public void InitializesAllVariables()
//        {
//            var parametrizacao = CreateParametrizacao();

//            Assert.Equal(_testMetricaId, parametrizacao.MetricaId);
//            Assert.Equal(_testPerfilId, parametrizacao.PerfilId);
//            Assert.Equal(_testIdade, parametrizacao.Idade);
//            Assert.Equal(_testValor, parametrizacao.Valor);
//            Assert.Equal(_testPercentual, parametrizacao.Quantidade);
//            Assert.Equal(_testMultiplicador, parametrizacao.Impacto);
//            Assert.Equal(_testDivisor, parametrizacao.Pontuacao);
//        }

//        [Fact]
//        public void ThrowsExceptionGivenNullMetrica()
//        {
//            var perfil = Perfil.Factory.NovoPerfil("teste", 1);
//            Action action = () => new ParametrizacaoMetrica(null, perfil);

//            var ex = Assert.Throws<ArgumentNullException>(action);
//            Assert.Equal("metrica", ex.ParamName);
//        }

//        [Fact]
//        public void ThrowsExceptionGivenNullPerfil()
//        {
//            var metrica = Metrica.Factory.NovaMetrica("teste");
//            Action action = () => new ParametrizacaoMetrica(metrica, null);

//            var ex = Assert.Throws<ArgumentNullException>(action);
//            Assert.Equal("perfil", ex.ParamName);
//        }

//        [Fact]
//        public void ThrowsExceptionGivenZeroPerfilId()
//        {
//            Action action = () => new ParametrizacaoMetrica(_testMetricaId, 0, _testIdade, _testPercentual, _testMultiplicador, _testValor, _testDivisor);

//            var ex = Assert.Throws<ArgumentException>(action);
//            Assert.Equal("perfilId", ex.ParamName);
//        }

//        [Fact]
//        public void ThrowsExceptionGivenZeroMetricaId()
//        {
//            Action action = () => new ParametrizacaoMetrica(0, _testPerfilId, _testIdade, _testPercentual, _testMultiplicador, _testValor, _testDivisor);

//            var ex = Assert.Throws<ArgumentException>(action);
//            Assert.Equal("metricaId", ex.ParamName);
//        }
//    }
//}

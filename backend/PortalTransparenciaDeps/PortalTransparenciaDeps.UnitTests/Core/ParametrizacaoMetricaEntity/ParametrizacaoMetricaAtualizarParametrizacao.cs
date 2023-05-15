//using PortalTransparenciaDeps.Core.DTO;
//using PortalTransparenciaDeps.Core.Entities.ParametrizacaoMetricaAggregate;
//using System;
//using Xunit;

//namespace PortalTransparenciaDeps.UnitTests.Core.ParametrizacaoMetricaEntity
//{
//    public class ParametrizacaoMetricaAtualizarParametrizacao
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
//        public void SetsNewValues()
//        {
//            var parametrizacao = CreateParametrizacao();

//            var novaParametrizacao = new CadastroParametrizacaoMetricaDto
//            {
//                Id = parametrizacao.Id,
//                Divisor = _testDivisor + 1,
//                Idade = _testIdade + 10,
//                MetricaId = _testMetricaId,
//                Multiplicador = _testMultiplicador + 100,
//                Percentual = _testPercentual + 1000,
//                Valor = _testValor + 10000,
//                PerfilId = _testPerfilId
//            };

//            parametrizacao.AtualizarParametrizacao(novaParametrizacao);

//            Assert.Equal(novaParametrizacao.Divisor, parametrizacao.Pontuacao);
//            Assert.Equal(novaParametrizacao.Idade, parametrizacao.Idade);
//            Assert.Equal(novaParametrizacao.Multiplicador, parametrizacao.Impacto);
//            Assert.Equal(novaParametrizacao.Percentual, parametrizacao.Quantidade);
//            Assert.Equal(novaParametrizacao.Valor, parametrizacao.Valor);
//            Assert.Equal(novaParametrizacao.MetricaId, parametrizacao.MetricaId);
//            Assert.Equal(novaParametrizacao.PerfilId, parametrizacao.PerfilId);
//        }

//        [Fact]
//        public void ThrowsExceptionGivenNull()
//        {
//            var parametrizacao = CreateParametrizacao();

//            Action action = () => parametrizacao.AtualizarParametrizacao(null);

//            var ex = Assert.Throws<ArgumentNullException>(action);
//            Assert.Equal("parametrizacao", ex.ParamName);
//        }

//        [Fact]
//        public void ThrowsExceptionGivenDifferentId()
//        {
//            var parametrizacao = CreateParametrizacao();

//            var novaParametrizacao = new CadastroParametrizacaoMetricaDto
//            {
//                Id = Guid.NewGuid(),
//                Divisor = _testDivisor + 1,
//                Idade = _testIdade + 10,
//                MetricaId = _testMetricaId,
//                Multiplicador = _testMultiplicador + 100,
//                Percentual = _testPercentual + 1000,
//                Valor = _testValor + 10000,
//                PerfilId = _testPerfilId
//            };

//            Action action = () => parametrizacao.AtualizarParametrizacao(novaParametrizacao);

//            var ex = Assert.Throws<ArgumentException>(action);
//            Assert.Equal("Id", ex.ParamName);
//        }

//        [Fact]
//        public void ThrowsExceptionGivenDifferentPerfilId()
//        {
//            var parametrizacao = CreateParametrizacao();

//            var novaParametrizacao = new CadastroParametrizacaoMetricaDto
//            {
//                Id = parametrizacao.Id,
//                MetricaId = _testMetricaId,
//                PerfilId = _testPerfilId + 5
//            };

//            Action action = () => parametrizacao.AtualizarParametrizacao(novaParametrizacao);

//            var ex = Assert.Throws<ArgumentException>(action);
//            Assert.Equal("PerfilId", ex.ParamName);
//        }

//        [Fact]
//        public void ThrowsExceptionGivenDifferentMetricaId()
//        {
//            var parametrizacao = CreateParametrizacao();

//            var novaParametrizacao = new CadastroParametrizacaoMetricaDto
//            {
//                Id = parametrizacao.Id,
//                MetricaId = _testMetricaId + 5,
//                PerfilId = _testPerfilId
//            };

//            Action action = () => parametrizacao.AtualizarParametrizacao(novaParametrizacao);

//            var ex = Assert.Throws<ArgumentException>(action);
//            Assert.Equal("MetricaId", ex.ParamName);
//        }
//    }
//}

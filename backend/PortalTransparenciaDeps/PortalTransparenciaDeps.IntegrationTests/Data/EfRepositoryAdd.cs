using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace PortalTransparenciaDeps.IntegrationTests.Data
{
    public class EfRepositoryAdd : BaseEfRepoTestFixture
    {
        [Fact]
        public async Task AddsPerfilAndSetsId()
        {
            var testPerfilName = "testPerfil";
            var repository = GetPerfilRepository();
            var perfil = Perfil.Factory.NovoPerfil(testPerfilName, 1);

            await repository.AddAsync(perfil);

            var novoPerfil = (await repository.ListAsync())
                                .FirstOrDefault();

            Assert.Equal(testPerfilName, novoPerfil.Nome);
            Assert.True(novoPerfil?.Id > 0);
        }

        //[Fact]
        //public async Task AddsParametrizacaoMetricaAndSetsId()
        //{
        //    var testPerfilName = "testPerfil";
        //    var perfil = Perfil.Factory.NovoPerfil(testPerfilName, 1);

        //    var testMetricaName = "testMetrica";
        //    var metrica = Metrica.Factory.NovaMetrica(testMetricaName);

        //    var perfilRepository = GetPerfilRepository();
        //    var metricaRepository = GetMetricaRepository();
        //    var parametrizacaoMetricaRepository = GetParametrizacaoMetricaRepository();

        //    await perfilRepository.AddAsync(perfil);
        //    await metricaRepository.AddAsync(metrica);

        //    var novoPerfil = (await perfilRepository.ListAsync())
        //                            .FirstOrDefault();

        //    var novaMetrica = (await metricaRepository.ListAsync())
        //                            .FirstOrDefault();

        //    var testIdade = 10;
        //    var testPercentual = 5m;
        //    var testMultiplicador = 1.76m;
        //    var testValor = 2500.56m;
        //    var testDivisor = 1.54m;
        //    var parametrizacaoMetrica = new ParametrizacaoMetrica(novaMetrica, novoPerfil, testIdade, testPercentual, testMultiplicador, testValor, testDivisor);

        //    await parametrizacaoMetricaRepository.AddAsync(parametrizacaoMetrica);

        //    var novaParametrizacaoMetrica = (await parametrizacaoMetricaRepository.ListAsync())
        //                                           .FirstOrDefault();

        //    Assert.Equal(novaParametrizacaoMetrica.Metrica.Id, novaMetrica.Id);
        //    Assert.Equal(novaParametrizacaoMetrica.Perfil.Id, novoPerfil.Id);
        //    Assert.True(Guid.Empty != novaParametrizacaoMetrica.Id);
        //    Assert.Equal(novaParametrizacaoMetrica.Idade, testIdade);
        //    Assert.Equal(novaParametrizacaoMetrica.Quantidade, testPercentual);
        //    Assert.Equal(novaParametrizacaoMetrica.Impacto, testMultiplicador);
        //    Assert.Equal(novaParametrizacaoMetrica.Valor, testValor);
        //    Assert.Equal(novaParametrizacaoMetrica.Pontuacao, testDivisor);
        //}

        // Não é possível testar o indice em bancos in memory
        //[Fact]
        //public async Task ThrowsExceptionGivenTwoEqualParametrizacaoMetricaAdded()
        //{
        //    var testPerfilName = "testPerfil";
        //    var perfil = Perfil.Factory.NovoPerfil(testPerfilName);

        //    var testMetricaName = "testMetrica";
        //    var metrica = Metrica.Factory.NovaMetrica(testMetricaName);

        //    var perfilRepository = GetPerfilRepository();
        //    var metricaRepository = GetMetricaRepository();
        //    var parametrizacaoMetricaRepository = GetParametrizacaoMetricaRepository();

        //    await perfilRepository.AddAsync(perfil);
        //    await metricaRepository.AddAsync(metrica);

        //    var novoPerfil = (await perfilRepository.ListAsync())
        //                            .FirstOrDefault();

        //    var novaMetrica = (await metricaRepository.ListAsync())
        //                            .FirstOrDefault();

        //    var testIdade = 10;
        //    var testPercentual = 5m;
        //    var testMultiplicador = 1.76m;
        //    var testValor = 2500.56m;
        //    var testDivisor = 1.54m;
        //    var parametrizacaoMetrica = new ParametrizacaoMetrica(novaMetrica, novoPerfil, testIdade, testPercentual, testMultiplicador, testValor, testDivisor);
        //    var parametrizacaoMetrica2 = new ParametrizacaoMetrica(novaMetrica, novoPerfil, testIdade, testPercentual, testMultiplicador, testValor, testDivisor);

        //    await parametrizacaoMetricaRepository.AddAsync(parametrizacaoMetrica);

        //    var ex = await Assert.ThrowsAsync<Exception>(async () => await parametrizacaoMetricaRepository.AddAsync(parametrizacaoMetrica2));
        //}

        //[Fact]
        //public async Task AddsClassificacaoAndSetsId()
        //{
        //    var testClassificacaoName = "testClassificacao";
        //    var repository = GetClassificacaoRepository();
        //    var classificacao = Classificacao.Factory.NovaClassificacao(testClassificacaoName, 1);

        //    await repository.AddAsync(classificacao);

        //    var novaClassificacao = (await repository.ListAsync())
        //                        .FirstOrDefault();

        //    Assert.Equal(testClassificacaoName, novaClassificacao.Nome);
        //    Assert.True(novaClassificacao?.Id > 0);
        //}

        //[Fact]
        //public async Task AddsPoliticaAndSetsId()
        //{
        //    var testPerfilName = "testPerfil";
        //    var perfil = Perfil.Factory.NovoPerfil(testPerfilName, 1);

        //    var testMetricaName = "testMetrica";
        //    var metrica = Metrica.Factory.NovaMetrica(testMetricaName);

        //    var classificacao = Classificacao.Factory.NovaClassificacao("testClassificacao", 1);

        //    var perfilRepository = GetPerfilRepository();
        //    var metricaRepository = GetMetricaRepository();
        //    var classificacaoRepository = GetClassificacaoRepository();

        //    await perfilRepository.AddAsync(perfil);
        //    await metricaRepository.AddAsync(metrica);
        //    await classificacaoRepository.AddAsync(classificacao);

        //    var novoPerfil = (await perfilRepository.ListAsync())
        //                            .FirstOrDefault();

        //    var novaMetrica = (await metricaRepository.ListAsync())
        //                            .FirstOrDefault();

        //    var novaClassificacao = (await classificacaoRepository.ListAsync())
        //                                  .FirstOrDefault();

        //    var testPoliticaName = Guid.NewGuid().ToString();
        //    var politica = Politica.Factory.NovaPolitica(testPoliticaName,
        //                                                 TipoPessoa.PESSOA_FISICA,
        //                                                 true,
        //                                                 new List<PoliticaClassificacao> { new PoliticaClassificacao { ClassificacaoId = novaClassificacao.Id } },
        //                                                 new List<PoliticaImpactoMetrica> { new PoliticaImpactoMetrica { MetricaId = novaMetrica.Id, PerfilId = novoPerfil.Id } });

        //    var politicaRepository = GetPoliticaRepository();
        //    await politicaRepository.AddAsync(politica);

        //    var novaPolitica = (await politicaRepository.ListAsync())
        //                             .FirstOrDefault();

        //    Assert.Equal(testPoliticaName, novaPolitica.Nome);
        //    Assert.True(novaPolitica.Id != Guid.Empty);
        //    Assert.True(novaPolitica.Classificacoes.Count() > 0);
        //    Assert.True(novaPolitica.ImpactoMetricas.Count() > 0);
        //}
    }
}

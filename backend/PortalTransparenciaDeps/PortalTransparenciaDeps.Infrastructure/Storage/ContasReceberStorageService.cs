using NLog;
using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.SharedKernel;
using PortalTransparenciaDeps.SharedKernel.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Infrastructure.Storage
{
    public class ContasReceberStorageService : IContasReceberStorageService
    {
        private readonly INoSqlRepository<ContasReceberDto> _crRepository;
        private readonly ILogger _logger;

        public ContasReceberStorageService(INoSqlRepository<ContasReceberDto> crRepository)
        {
            _crRepository = crRepository;
            _logger = LogManager.GetCurrentClassLogger();
        }

        public ContasReceberDto ObterCr(Guid clienteId, string documento)
        {
            try
            {
                var clienteIdString = clienteId.ToString();
                var cr = _crRepository.FilterBy(x => x.ClienteId == clienteIdString && x.Documento == documento).OrderByDescending(x => x.Dados.DataPosicao).FirstOrDefault();

                return cr;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Erro ao obter CR no MongoDB. {ex.Message}");
            }

            return null;
        }

        public PagedList<ContasReceberDto> ListarCr(Guid clienteId, string documento, string pesquisa, int? page = null, int? size = null)
        {
            try
            {
                IEnumerable<ContasReceberDto> cr;

                var filter = Filter.Create<ContasReceberDto>()
                                   .And(x => x.ClienteId == clienteId.ToString())
                                   .AndWhen(x => x.Documento.Contains(pesquisa), () => !string.IsNullOrEmpty(pesquisa))
                                   .AndWhen(x => x.Documento == documento, () => !string.IsNullOrEmpty(documento));

                var projection = Projection.Create<ContasReceberDto>
                (
                    x => new ContasReceberDto
                    {
                        ClienteId = x.ClienteId,
                        Documento = x.Documento,
                        Data = x.Data,
                        Dados = new DadosComplementaresAnaliseDto
                        {
                            DataPosicao = x.Dados.DataPosicao,
                            MaiorLimiteTomado = x.Dados.MaiorLimiteTomado,
                            ContasReceberResumido = x.Dados.ContasReceberResumido,
                            ContasReceberDetalhado = x.Dados.ContasReceberDetalhado.Select(y => new ContasReceberDetalhadoDto
                            {
                                Tipo = y.Tipo
                            })
                        }
                    }
                );

                if (page.HasValue && size.HasValue)
                {
                    var skip = (page.GetValueOrDefault() - 1) * size.GetValueOrDefault();
                    var take = size.GetValueOrDefault();

                    cr = _crRepository.FilterBy(filter, projection, skip, take);
                }
                else
                {
                    cr = _crRepository.FilterBy(filter, projection);
                }

                var crCount = _crRepository.Count(filter);

                return new PagedList<ContasReceberDto>
                {
                    TotalItems = crCount,
                    Items = cr.OrderByDescending(x => x.Dados.DataPosicao)
                              .ToList()
                };
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Erro ao listar CR no MongoDB. {ex.Message}");
            }

            return null;
        }

        public PagedList<ContasReceberDetalhadoDetalheDto> ListarCrDetalhado(Guid clienteId, string documento, TipoContaReceber tipo, int? page = null, int? size = null)
        {
            try
            {
                var filter = Filter.Create<ContasReceberDto>()
                                   .And(x => x.ClienteId == clienteId.ToString())
                                   .And(x => x.Documento == documento);

                var projectionItems = Projection.Create<ContasReceberDto>();

                var projectionCount = Projection.Create<ContasReceberDto, ContasReceberDetalhadoDto>(x => x.Dados.ContasReceberDetalhado.First(y => y.Tipo == tipo));

                if (page.HasValue)
                {
                    var skip = (page.GetValueOrDefault() - 1) * size.GetValueOrDefault();
                    var take = size.GetValueOrDefault();

                    projectionItems = Projection.Create<ContasReceberDto>(x => new ContasReceberDto
                    {
                        ClienteId = x.ClienteId,
                        Documento = x.Documento,
                        Data = x.Data,
                        Dados = new DadosComplementaresAnaliseDto
                        {
                            ContasReceberDetalhado = x.Dados.ContasReceberDetalhado.Select(y => new ContasReceberDetalhadoDto
                            {
                                Tipo = y.Tipo,
                                Detalhes = y.Detalhes.Skip(skip).Take(take)
                            })
                        }
                    });
                }
                else
                {
                    projectionItems = Projection.Create<ContasReceberDto>(x => new ContasReceberDto
                    {
                        ClienteId = x.ClienteId,
                        Documento = x.Documento,
                        Data = x.Data,
                        Dados = new DadosComplementaresAnaliseDto
                        {
                            ContasReceberDetalhado = x.Dados.ContasReceberDetalhado.Select(y => new ContasReceberDetalhadoDto
                            {
                                Tipo = y.Tipo,
                                Detalhes = y.Detalhes
                            })
                        }
                    });
                }

                var crDetalhado = _crRepository.FilterBy(filter, projectionItems)
                                               .FirstOrDefault().Dados.ContasReceberDetalhado
                                               .FirstOrDefault(x => x.Tipo == tipo).Detalhes
                                               .ToList();

                var crDetalhadoCount = _crRepository.FilterBy(filter, projectionCount)
                                                    .FirstOrDefault().Detalhes
                                                    .Count();

                return new PagedList<ContasReceberDetalhadoDetalheDto>
                {
                    TotalItems = crDetalhadoCount,
                    Items = crDetalhado
                };
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Erro ao listar CR no MongoDB. {ex.Message}");
            }

            return null;
        }

        public async Task SalvarCr(List<ContasReceberDto> dto)
        {
            try
            {
                foreach (var item in dto)
                {
                    await _crRepository.DeleteManyAsync(cr => cr.Documento == item.Documento && cr.ClienteId == item.ClienteId);
                }

                await _crRepository.InsertManyAsync(dto);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Erro ao salvar CR no MongoDB. {ex.Message}");
                _logger.Debug($"CrDto: {dto.ToJson()}");
            }
        }
    }
}

using NPOI.SS.Formula.Functions;
using PortalTransparenciaDeps.Web.ExternalDTOs;
using PortalTransparenciaDeps.Web.Models.BeneficiosAggregate;
using PortalTransparenciaDeps.Web.Models.SancoesAggregate;
using PortalTransparenciaDeps.Web.Models.ServidoresAggregate;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Web.ExternalInterfaces
{
    public interface IPortalTransparencia
    {
        //BENEFÍCIOS
        Task<ExternalResponseList<BolsaFamiliaModel>> GetBolsaFamiliaByCpf(int dataCompetencia, int dataReferencia, string codigo, int pagina);
        Task<ExternalResponseList<BpcModel>> GetBpcByCpf(string cpf, int pagina);
        Task<ExternalResponseList<PetiModel>> GetPetiByCpf(string codigo, int pagina);

        //SERVIDORES DO PODER EXECUTIVO FEDERAL

        Task<ExternalResponseList<PepModel>> GetPepByCpf(string cpf, int pagina);
        Task<ExternalResponseList<RemuneracaoModel>> GetRemuneracaoByCpf(string cpf, int data, int pagina);

        //SANÇÕES
        
        Task<ExternalResponseList<LenienciaModel>> GetLenienciaByCnpj(string cnpj, int pagina);
        Task<ExternalResponseList<CepimModel>> GetCepimByCnpj(string cnpj, int pagina);
        Task<ExternalResponseList<CnepModel>> GetCnepByCnpj(string cnpj, int pagina);
    }
        
}

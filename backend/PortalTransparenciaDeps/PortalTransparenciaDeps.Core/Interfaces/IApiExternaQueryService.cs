using PortalTransparenciaDeps.Core.Models.PortalTransparenciaAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface IApiExternaQueryService
    {
        List<BolsaFamiliaModel> ListBolsaFamilia(int id);
        List<BpcModel> ListBpc(int id);
        List<CepimModel> ListCepim(int id);
        List<CnepModel> ListCnep(int id);
        List<LenienciaModel> ListLeniencia(int id);
        List<MunicipioModel> ListMunicipio(int id);
        List<PepModel> ListPep(int id);
        List<PessoaJuridicaModel> ListPessoaJuridica(int id);
        List<PetiModel> ListPeti(int id);
        List<RemuneracaoModel> ListRemuneracao(int id);
        List<UfModel> ListUf(int id);
    }

}

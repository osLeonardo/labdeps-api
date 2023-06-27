namespace PortalTransparenciaDeps.Web.Endpoints.PortalTransparenciaEndpoints
{
    public class GetHistoricoResponse
    {
        public virtual GetBolsaFamiliaDBResponse BolsaFamiliaDB { get; set; }
        public virtual GetBpcDBResponse BpcDB { get; set; }
        public virtual GetCepimDBResponse CepimDB { get; set; }
        public virtual GetCnepDBResponse CnepDB { get; set; }
        public virtual GetLenienciaDBResponse LenienciaDB { get; set; }
        public virtual GetPepDBResponse BolsaPepDB { get; set; }
        public virtual GetPetiDBResponse PetiDB { get; set; }
        public virtual GetRemuneracaoDBResponse RemuneracaoDB { get; set; }
    }
}

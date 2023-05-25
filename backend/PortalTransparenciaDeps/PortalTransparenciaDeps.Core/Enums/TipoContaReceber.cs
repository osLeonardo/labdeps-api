using System.ComponentModel;

namespace PortalTransparenciaDeps.Core.Enums
{
    public enum TipoContaReceber
    {
        [Description("Histórico de pagamento")]
        HISTORICO_PAGAMENTO = 1,

        [Description("Relação de vencidos")]
        RELACAO_VENCIDOS = 2,

        [Description("Relação à vencer")]
        RELACAO_VENCER = 3
    }
}

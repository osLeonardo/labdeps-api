using System.ComponentModel;

namespace PortalTransparenciaDeps.Core.Enums
{
    public enum PerfilUsuario
    {
        [Description("Automação")]
        Automacao,

        [Description("Administrador do portal")]
        AdministradorPortal,

        [Description("Administrador do parceiro")]
        AdministradorParceiro,

        [Description("Usuário gestor")]
        UsuarioGestor,

        [Description("Usuário")]
        Usuario,

        [Description("Gerente comercial")]
        GerenteComercial,

        [Description("Comercial")]
        Comercial,

        [Description("Suporte e implantação")]
        SuporteImplantacao,

        [Description("Financeiro")]
        Financeiro
    }
}

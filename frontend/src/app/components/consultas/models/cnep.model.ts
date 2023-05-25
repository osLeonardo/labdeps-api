import { FonteSancao } from "./fonteSancao.model";
import { Fundamentacao } from "./fundamentacao.model";
import { OrgaoSancionador } from "./orgaoSancionador.model";
import { PessoaJuridica } from "./pessoaJuridica.model";
import { Sancionado } from "./sancionado.model";
import { TipoSancao } from "./tipoSancao.model";

export interface Cnep{
        abrangenciaDefinidaDecisaoJudicial : string;
        dataFimSancao: string;
        dataInicioSancao: string;
        dataOrigemInformacao: string;
        dataPublicacaoSancao: string
        dataReferencia: string;
        dataTransitadoJulgado: string
        detalhamentoPublicacao: string
        fonteSancao: FonteSancao;
        fundamentacao: Fundamentacao[];
        id: number;
        informacoesAdicionaisDoOrgaoSancionador: string;
        linkPublicacao: string;
        numeroProcesso: string
        orgaoSancionador: OrgaoSancionador;
        pessoa: PessoaJuridica;
        sancionado: Sancionado;
        textoPublicacao: string;
        tipoSancao: TipoSancao;
        valorMulta: string;
}
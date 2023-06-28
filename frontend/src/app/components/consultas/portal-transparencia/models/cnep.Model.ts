import { TipoSancao } from './tipoSancao.Model';
import { FonteSancao } from "./fonteSancao.Model";
import { Fundamentacao } from "./fundamentacao.Model";
import { OrgaoSancionador } from "./orgaoSancionador.Model";
import { PessoaJuridica } from "./pessoaJuridica.Model";
import { Sancionado } from "./sancionado.Model";

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

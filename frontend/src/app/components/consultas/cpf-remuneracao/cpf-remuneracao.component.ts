import { Component, OnInit } from '@angular/core';
import { Remuneracao, RemuneracoesDto } from '../models/remuneracao.model';
import { ConsultasService } from '../consultas.service';
import { animate, state, style, transition, trigger } from '@angular/animations';

@Component({
  selector: 'app-cpf-remuneracao',
  templateUrl: './cpf-remuneracao.component.html',
  styleUrls: ['./cpf-remuneracao.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({ height: '0px', minHeight: '0' })),
      state('expanded', style({ height: '*' })),
      transition(
        'expanded <=> collapsed',
        animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')
      ),
    ]),
  ]
})
export class CpfRemuneracaoComponent implements OnInit {

  constructor(private CpfRemuneracao: ConsultasService) { }

  remuneracao: Remuneracao[];
  dataSource = element_data;
  columnsToDisplay = ['mesAno', 'remuneracaoBasicaBruta', 'gratificacaoNatalina', 'ferias', 'outrasRemuneracoesEventuais', 'fundoSaude'];
  columnsToDisplayWithExpand = [...this.columnsToDisplay, 'expand'];
  expandedElement: RemuneracoesDto | null;
  columnsToDisplayExpanded = [
    'impostoRetidoNaFonte',
    'taxaOcupacaoImovelFuncional',
    'outrasDeducoesObrigatorias',
    'valorTotalRemuneracaoAposDeducoes',
    'pensaoMilitar',
    'previdenciaOficial',
  ];
  columnTable2 = [
    'verbasIndenizatorias',
    'verbasIndenizatoriasCivil',
    'verbasIndenizatoriasMilitar',
    'valorTotalHonorariosAdvocaticios',
    'verbasIndenizatoriasReferentesPDV',
    'observacoes',
  ]
  columnHonorariosAdvocaticios = [
    'mensagemMesReferencia',
    'mesReferencia',
    'valor',
    'valorFormatado',
  ]
   
  ngOnInit(): void {
      const codigo = "";
      const dataCompetencia = 0;

      this.CpfRemuneracao.GetRemuneracaoByCpf(codigo, dataCompetencia).subscribe(remuneracao => {
        this.remuneracao = remuneracao
      })
  }
}

const element_data: RemuneracoesDto[] = [
  {
    abateGratificacaoNatalina: "3600.00",
    abateGratificacaoNatalinaDolar: "",
    abateRemuneracaoBasicaBruta: "4200.00",
    abateRemuneracaoBasicaBrutaDolar: "",
    existeValorMes: true,
    ferias: "12600.00",
    feriasDolar: "",
    fundoSaude: "850.00",
    fundoSaudeDolar: "",
    gratificacaoNatalina: "3600.00",
    gratificacaoNatalinaDolar: "",
    honorariosAdvocaticios: [{
      mensagemMesReferencia: "Setembro",
      mesReferencia: "09",
      valor: 250,
      valorFormatado: "250.00"
    }],
    impostoRetidoNaFonte: "10.00",
    impostoRetidoNaFonteDolar: "",
    jetons: [{
      descricao: "O Que é um Jeton?",
      mesReferencia: "09",
      valor: 160
    }],
    mesAno: "09/2020",
    mesAnoPorExtenso: "Setembro de Dois Mil e Vinte",
    observacoes: ["string"],
    outrasDeducoesObrigatorias: "20.00",
    outrasDeducoesObrigatoriasDolar: "",
    outrasRemuneracoesEventuais: "180.00",
    outrasRemuneracoesEventuaisDolar: "",
    pensaoMilitar: "70.00",
    pensaoMilitarDolar: "",
    previdenciaOficial: "90.00",
    previdenciaOficialDolar: "",
    remuneracaoBasicaBruta: "4200.00",
    remuneracaoBasicaBrutaDolar: "",
    remuneracaoEmpresaPublica: true,
    rubricas: [{
        codigo: "9999",
        descricao: "Rubrica com Valor?",
        skMesReferencia: "09",
        valor: 8000,
        valorDolar: 0,
      }],
    skMesReferencia: "90",
    taxaOcupacaoImovelFuncional: "1.5",
    taxaOcupacaoImovelFuncionalDolar: "",
    valorTotalHonorariosAdvocaticios: "800.00",
    valorTotalJetons: "200.00",
    valorTotalRemuneracaoAposDeducoes: "10.00",
    valorTotalRemuneracaoDolarAposDeducoes: "",
    verbasIndenizatorias: "900.00",
    verbasIndenizatoriasCivil: "850.00",
    verbasIndenizatoriasCivilDolar: "",
    verbasIndenizatoriasDolar: "",
    verbasIndenizatoriasMilitar: "96.00",
    verbasIndenizatoriasMilitarDolar: "",
    verbasIndenizatoriasReferentesPDV: "11111111.11",
    verbasIndenizatoriasReferentesPDVDolar: "",
  }
]

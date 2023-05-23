import { ActivatedRoute } from '@angular/router';
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

  
  remuneracao: Remuneracao[];

  constructor(
    private consultaService: ConsultasService,
    private route: ActivatedRoute,
    ) { }

    ngOnInit(): void {
      const codigo = `${this.route.snapshot.paramMap.get('codigo')}`;
      const dataCompetencia = `${this.route.snapshot.paramMap.get('dataRef')}`;

      this.consultaService.GetRemuneracaoByCpf(codigo, dataCompetencia).subscribe(remuneracao => {
        this.remuneracao = remuneracao;
      })
  }

  columnsToDisplay = [
    'mesAno',
    'remuneracaoBasicaBruta',
    'gratificacaoNatalina',
    'ferias',
    'outrasRemuneracoesEventuais',
    'fundoSaude'
  ];
  columnsToDisplayWithExpand = [...this.columnsToDisplay, 'expand'];
  expandedElement: RemuneracoesDto | null;
  columnTable1 = [
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
  ];
  observacao = [
    'observacoes',
  ];
  honorarios = [
    'mesReferencia',
    'valor',
  ];
  jetons = [
    'descricao',
    'mesReferencia',
    'valor',
  ];
  rubricas = [
    'codigo',
    'descricao',
    'skMesReferencia',
    'valor',
  ];
}

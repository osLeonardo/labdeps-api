
import { ConsultasService } from "./../consultas.service";
import { Component, OnInit } from "@angular/core";
import { animate, state, style, transition, trigger } from '@angular/animations';
import { Sancoes } from "../model/sancoes.Model";
import { LenienciaByCnpj } from "../model/lenienciaByCnpj.Model";

@Component({
  selector: "app-cnpj-lenencia",
  templateUrl: "./cnpj-lenencia.component.html",
  styleUrls: ["./cnpj-lenencia.component.css"],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})


export class CnpjLenenciaComponent implements OnInit {

  dataSource = element_data;
  columnsToDisplay =  [ 'id','orgaoResponsavel','situacaoAcordo', 'dataFimAcordo', 'dataInicioAcordo', 'quantidade'  ];
  columnsToDisplayWithExpand = [...this.columnsToDisplay, 'expand'];
  expandedElement: Sancoes | null;

  dataSource2 = sancoes;
  columnsDisplay = ['nomeFantasia', 'nomeInformadoOrgaoResponsavel','razaoSocial', 'cnpj', 'cnpjFormatado']
  

  leniencia: LenienciaByCnpj[]

  constructor(private ConsultasService: ConsultasService) {}

  ngOnInit(): void {
    const codigo = "06947283000160"; // mudar dps para a rota que vamos fazer
    this.ConsultasService.GetLenienciaByCnpj(codigo).subscribe((lenencia) => {
      this.leniencia = lenencia;
      console.log(lenencia)
    });
  }

}


const element_data: LenienciaByCnpj[] = [
  {
    dataFimAcordo: '14/02/2003',
    dataInicioAcordo: '14/02/2005',
    id: 1,
    orgaoResponsavel: 'joao',
    quantidade: 20,
    sancoes: [

    ],
    situacaoAcordo: 'fudido'
  },
  {
    dataFimAcordo: '14/02/2005',
    dataInicioAcordo: '14/02/2005',
    id: 2,
    orgaoResponsavel: 'jhulia',
    quantidade: 20,
    sancoes: [

    ],
    situacaoAcordo: 'desesperada'
  }

]

const sancoes: Sancoes[] = [
  {
    cnpj: '52468426146',
    cnpjFormatado: '52468426146',
    nomeFantasia: 'beto',
    nomeInformadoOrgaoResponsavel: 'tbm n sei',
    razaoSocial: 'divertir'
  },
  {
    cnpj: '454821486248',
    cnpjFormatado: '454821486248',
    nomeFantasia: 'disnei',
    nomeInformadoOrgaoResponsavel: 'disney',
    razaoSocial: 'perder dinheiro'
  }
]



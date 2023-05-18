


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
  columnsToDisplay =  [ 'orgaoResponsavel','situacaoAcordo', 'dataFimAcordo', 'dataInicioAcordo', 'quantidade'  ];
  columnsToDisplayWithExpand = [...this.columnsToDisplay, 'expand'];

  expandedElement: LenienciaByCnpj | null;

  dataSource2: LenienciaByCnpj[]
  columnsDisplay = ['cnpjFormatado', 'nomeFantasia', 'nomeInformadoOrgaoResponsavel','razaoSocial', ]
  

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
    orgaoResponsavel: 'Deps',
    quantidade: 15,
    sancoes: [
      {
        cnpj: '06947283000160',
        cnpjFormatado: '06.947.283/0001-60',
        nomeFantasia: 'google',
        nomeInformadoOrgaoResponsavel: 'google',
        razaoSocial: 'divertir'
      },
      {
        cnpj: '07031983000172',
        cnpjFormatado: '07.031.983/0001-72',
        nomeFantasia: 'Deps',
        nomeInformadoOrgaoResponsavel: 'Deps',
        razaoSocial: 'ganhar um emprego'
      }
    ],
    situacaoAcordo: 'importancia'
  },


  {
    dataFimAcordo: '14/02/2005',
    dataInicioAcordo: '14/02/2005',
    id: 2,
    orgaoResponsavel: 'google',
    quantidade: 20,
    sancoes: [
      {
        cnpj: '06947283000160',
        cnpjFormatado: '06.947.283/0001-60',
        nomeFantasia: 'beto',
        nomeInformadoOrgaoResponsavel: 'tbm n sei',
        razaoSocial: 'divertir'
      },

    ],
    situacaoAcordo: 'desesperada'
  }

]





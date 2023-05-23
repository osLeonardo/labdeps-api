


import { ConsultasService } from "./../consultas.service";
import { Component, OnInit } from "@angular/core";
import { animate, state, style, transition, trigger } from '@angular/animations';

import { LenienciaByCnpj } from "../models/lenienciaByCnpj.Model";
import { ActivatedRoute } from "@angular/router";



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

  leniencia: LenienciaByCnpj[]

  constructor(private ConsultasService: ConsultasService, private route: ActivatedRoute) {}

  ngOnInit(): void {
    const codigo: string = `${this.route.snapshot.paramMap.get('codigo')}`;
    this.ConsultasService.GetLenienciaByCnpj(codigo).subscribe((lenencia) => {
      this.leniencia = lenencia;
      console.log(lenencia)
    });
  }

  columnsToDisplay =  [ 'orgaoResponsavel','situacaoAcordo', 'dataFimAcordo', 'dataInicioAcordo', 'quantidade'];
  
  columnsToDisplayWithExpand = [...this.columnsToDisplay, 'expand'];

  expandedElement:null

  dataSource2: LenienciaByCnpj[]
  columnsDisplay = ['cnpjFormatado', 'nomeFantasia', 'nomeInformadoOrgaoResponsavel','razaoSocial', ]

}






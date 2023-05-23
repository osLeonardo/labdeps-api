import { Component } from '@angular/core';
import {animate, state, style, transition, trigger} from '@angular/animations';

@Component({
  selector: 'app-cpf-bpc',
  templateUrl: './cpf-bpc.component.html',
  styleUrls: ['./cpf-bpc.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class CpfBpcComponent {

  dataSource = elementos
  displayedColumns = ["id", "cpf", "nome", "nis", "pais", "uf_nome"]
	
  columnsToDisplayWithExpand = [...this.displayedColumns, 'expand'];
  expandedElement:  classeTeste[];

}

export interface classeTeste {
  nome: string,
  cpf: string,
  nis: string,
  nome_rep: string,
  cpf_rep: string,
  nis_rep: string,
  pais: string,
  uf_nome: string,
  id: number,
  dataMesCompetencia: string,
  dataMesReferencia: string
}

const elementos: classeTeste[] = [
  {
      nome: "Bruno",
      cpf: "514.325.652-68",
      nis: "4562548",
      nome_rep: "Jhulia",
      cpf_rep: "852.963.741.65",
      nis_rep: "4521489",
      pais: "Brasil",
      uf_nome: "Santa Catarina",
      id: 1,
      dataMesCompetencia: "06/2021",
      dataMesReferencia: "07/2022"
 }
]

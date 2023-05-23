import { Component } from '@angular/core';
import {animate, state, style, transition, trigger} from '@angular/animations';

@Component({
  selector: 'app-cpf-peps',
  templateUrl: './cpf-peps.component.html',
  styleUrls: ['./cpf-peps.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class CpfPepsComponent {

  displayedColumns = ["cpf", "nome", "funcao", "orgao", "inicio_exercicio", "fim_exercicio"]
	dataSource = elementos

  columnsToDisplayWithExpand = [...this.displayedColumns, 'expand'];
  expandedElement:  classeTeste[];
}

export interface classeTeste {
  nome: string,
  cpf: string,
  orgao: string,
  funcao: string,
  inicio_exercicio: string,
  fim_exercicio: string,
  cod_orgao: number,
  sigla_funcao: string,
  nivel_funcao: string,
  fim_carencia: string,
  cod_funcao: number
}

const elementos: classeTeste[] = [
  {
      nome: "Karen Bialescki Stackoski",
      cpf: "789.654.852-98",
      orgao: "Deps",
      funcao: "Dev",
      inicio_exercicio: "12/02/2023",
      fim_exercicio: "12/02/2036",
      cod_orgao: 1,
      sigla_funcao: "AAA",
      nivel_funcao: "alto",
      fim_carencia: "12/12/2056",
      cod_funcao: 1
 }
]
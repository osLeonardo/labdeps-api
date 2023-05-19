import { Component } from '@angular/core';

@Component({
  selector: 'app-cpf-peps',
  templateUrl: './cpf-peps.component.html',
  styleUrls: ['./cpf-peps.component.css']
})
export class CpfPepsComponent {

  displayedColumns = ["cpf", "nome", "funcao", "orgao", "inicio_exercicio", "fim_exercicio"]
	dataSource = elementos

}

export interface classeTeste {
  nome: string,
  cpf: string,
  orgao: string,
  funcao: string,
  inicio_exercicio: string,
  fim_exercicio: string
}

const elementos: classeTeste[] = [
  {
      nome: "Karen Bialescki Stackoski",
      cpf: "789.654.852-98",
      orgao: "Deps",
      funcao: "Dev",
      inicio_exercicio: "12/02/2023",
      fim_exercicio: "12/02/2036"
 }
]
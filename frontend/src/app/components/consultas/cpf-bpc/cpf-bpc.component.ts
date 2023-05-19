import { Component } from '@angular/core';

@Component({
  selector: 'app-cpf-bpc',
  templateUrl: './cpf-bpc.component.html',
  styleUrls: ['./cpf-bpc.component.css']
})
export class CpfBpcComponent {

  displayedColumns = ["cpf", "nome", "nis", "cpf_rep", "nome_rep", "nis_rep", "pais", "uf_nome"]
	dataSource = elementos
}

export interface classeTeste {
  nome: string,
  cpf: string,
  nis: string,
  nome_rep: string,
  cpf_rep: string,
  nis_rep: string,
  pais: string,
  uf_nome: string
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
      uf_nome: "Santa Catarina"
 }
]

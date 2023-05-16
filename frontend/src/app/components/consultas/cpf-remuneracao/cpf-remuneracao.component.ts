import { Component, OnInit } from '@angular/core';
import { Remuneracao } from '../models/remuneracao.model';
import { ConsultasService } from '../consultas.service';

@Component({
  selector: 'app-cpf-remuneracao',
  templateUrl: './cpf-remuneracao.component.html',
  styleUrls: ['./cpf-remuneracao.component.css']
})
export class CpfRemuneracaoComponent implements OnInit {

  remuneracao: Remuneracao[]

  constructor(private CpfRemuneracao: ConsultasService) { }
   
  ngOnInit(): void {
      const codigo = "";
      const dataCompetencia = 0;

      this.CpfRemuneracao.GetRemuneracaoByCpf(codigo, dataCompetencia).subscribe(remuneracao => {
        this.remuneracao = remuneracao
      })
  }
}

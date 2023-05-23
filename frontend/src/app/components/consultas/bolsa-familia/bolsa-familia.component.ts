import { Component } from '@angular/core';
import { bolsaFamilia } from '../models/bolsaFamilia.Model';

@Component({
  selector: 'app-bolsa-familia',
  templateUrl: './bolsa-familia.component.html',
  styleUrls: ['./bolsa-familia.component.css']
})

//coisas sobre a tabela
export class BolsaFamiliaComponent {
  BolsaFamiliaList = bolsafamiliaResult;
  displayedColumns = ['nome', 'cpfFormatado', 'nis', 'quantidadeDependentes', 'valor', 'dataMesCompetencia', 'nomeIBGE', 'sigla'];
}

const bolsafamiliaResult: bolsaFamilia[] = 
[
  {
    id: 0,
    dataMesCompetencia: "",
    quantidadeDependentes: 0,
    valor: 0,
    municipio: 
    {
      codigoIBGE: "",
      codigoRegiao: "",
      nomeIBGE: "",
      nomeRegiao: "",
      pais: "",
      uf: 
      {
        nome: "",
        sigla: "",
      }
    },
    titularBolsaFamilia:
    {
      cpfFormatado: "",
      nis: "",
      nome: "",
    }
  }
]
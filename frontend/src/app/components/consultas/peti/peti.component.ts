import { Component } from '@angular/core';
import { peti } from '../model/peti.Model';

@Component({
  selector: 'app-peti',
  templateUrl: './peti.component.html',
  styleUrls: ['./peti.component.css']
})

//coisas sobre a tabela
export class PetiComponent {
  PetiList = petiResult;
  displayedColumns = ['nome', 'cpfFormatado', 'nis', 'situacao', 'dataDisponibilizacaoRecurso', 'dataMesReferencia', 'nomeIBGE', 'sigla'];
}

const petiResult: peti[] = 
[
  {
    beneficiarioPeti:
    {
      cpfFormatado: "",
      nis: "",
      nome: "",
    },
    dataDisponibilizacaoRecurso: "",
    dataMesReferencia: "",
    id: 0,
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
    situacao: "",
    valor: 0,
  }
]

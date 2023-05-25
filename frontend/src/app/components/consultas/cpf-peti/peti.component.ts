import { Component, OnInit } from '@angular/core';
import { peti } from '../models/peti.Model';
import { ConsultasService } from '../consultas.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-peti',
  templateUrl: './peti.component.html',
  styleUrls: ['./peti.component.css']
})

//coisas sobre a tabela
export class PetiComponent implements OnInit{
  peti: peti[]

  constructor(
    private consultasService: ConsultasService,
    private route: ActivatedRoute
  ){}
  
  ngOnInit(): void {
    const codigo: string = `${this.route.snapshot.paramMap.get('codigo')}`
    this.consultasService.GetPetiByCpf(codigo).subscribe(peti =>{
      this.peti = peti
    });
}

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

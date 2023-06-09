import { Component, OnInit } from '@angular/core';
import { bolsaFamilia } from '../models/bolsaFamilia.Model';
import { ConsultasService } from '../consultas.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-bolsa-familia',
  templateUrl: './bolsa-familia.component.html',
  styleUrls: ['./bolsa-familia.component.css']
})

//coisas sobre a tabela
export class BolsaFamiliaComponent implements OnInit {
  
  bolsaFamilia: bolsaFamilia[] = [];
  constructor(
    private consultasService: ConsultasService,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    const codigo: string = `${this.route.snapshot.paramMap.get('codigo')}`
    const dataRef = `${this.route.snapshot.paramMap.get('dataRef')}`
    const intervalo = parseInt(`${this.route.snapshot.paramMap.get('intervalo')}`)
    const auxDate = parseInt(dataRef);
    const ano = parseInt(dataRef.substring(0, 4));
    const mes = parseInt(dataRef.substring(4, 6)) - 1; //-1 pois janeiro é representado por 0
    let data = new Date(ano, mes);

    for(let i=0; i<intervalo; i++){
      data.setMonth(data.getMonth()-1);
      let dataCompetencia = parseInt(`${data.getFullYear().toString()}${(data.getMonth() + 1).toString().padStart(2, '0')}`);
      this.consultasService.GetBolsaFamiliaByCpf(dataCompetencia, codigo).subscribe(bolsafamilia =>{
        for(let element of bolsafamilia){
          this.bolsaFamilia = [...this.bolsaFamilia, element]
        }
      });
      
    }
  }
  

  displayedColumns = [
    "nome",
    "cpfFormatado",
    "nis",
    "quantidadeDependentes",
    "valor",
    "dataMesCompetencia",
    "nomeIBGE",
    "sigla",
  ];
}


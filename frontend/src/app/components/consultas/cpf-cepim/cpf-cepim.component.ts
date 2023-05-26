import { Component, OnInit } from '@angular/core';
import { CepimByCnpj } from '../models/cepimByCnpj.Model';
import { ConsultasService } from '../consultas.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-cpf-cepim',
  templateUrl: './cpf-cepim.component.html',
  styleUrls: ['./cpf-cepim.component.css']
})
export class CpfCepimComponent implements OnInit{

  cepim: CepimByCnpj[];

  constructor(private ConsultasService: ConsultasService, private route: ActivatedRoute) { }

  ngOnInit(): void {

    const codigo: string = `${this.route.snapshot.paramMap.get('codigo')}`;
     this.ConsultasService.GetCepimByCnpj(codigo).subscribe((cepim) => {
       this.cepim = cepim;
     });
  }

  columnsToDisplay = [
    "pessoaJuridica.nome", 
    "pessoaJuridica.tipo", 
    "motivo",
    "pessoaJuridica.cpfFormatado",
    "dataReferencia"
  ];

  columnsToDisplayWithExpand = [...this.columnsToDisplay, 'expand'];
  expandedElement: null
  dataSource2: CepimByCnpj[]
  columnsDisplay = ["convenio", "orgaoSuperior", "orgaoMaximo", ""]


}

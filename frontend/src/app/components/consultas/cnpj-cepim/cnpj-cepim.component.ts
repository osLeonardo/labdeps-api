import { CepimByCnpj } from './../model/cepimByCnpj.Model';
import { Component, OnInit } from '@angular/core';

import { ConsultasService } from '../consultas.service';

@Component({
  selector: 'app-cnpj-cepim',
  templateUrl: './cnpj-cepim.component.html',
  styleUrls: ['./cnpj-cepim.component.css']
})
export class CnpjCepimComponent implements OnInit {

  cepim: CepimByCnpj[];

  constructor(private ConsultasService: ConsultasService) {}

  ngOnInit(): void {
    const codigo = "06947283000160"; // mudar dps para a rota que vamos fazer
    this.ConsultasService.GetCepimByCnpj(codigo).subscribe((cepim) => {
      this.cepim = cepim;
      console.log(cepim)
    });
  }
}

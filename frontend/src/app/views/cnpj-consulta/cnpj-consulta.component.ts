import { Component } from '@angular/core';
import { HeaderService } from 'src/app/components/template/header/header.service';

@Component({
  selector: 'app-cnpj-consulta',
  templateUrl: './cnpj-consulta.component.html',
  styleUrls: ['./cnpj-consulta.component.css']
})
export class CnpjConsultaComponent {

  constructor(private headerService: HeaderService) {
    headerService.headerData = {
      title: 'Consultas / CNPJ',
      icon: ' search ',
      routeUrl: '/consulta',
    }
  }

}

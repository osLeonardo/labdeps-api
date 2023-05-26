import { Component } from '@angular/core';
import { HeaderService } from 'src/app/components/template/header/header.service';

@Component({
  selector: 'app-cpf-consulta',
  templateUrl: './cpf-consulta.component.html',
  styleUrls: ['./cpf-consulta.component.css']
})
export class CpfConsultaComponent {

  constructor(private headerService: HeaderService) {
    headerService.headerData = {
      title: 'Consultas / CPF',
      icon: ' search ',
      routeUrl: '/consulta',
    }
  }
  
}

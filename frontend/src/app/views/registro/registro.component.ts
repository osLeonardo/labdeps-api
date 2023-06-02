import { Component } from '@angular/core';
import { HeaderService } from 'src/app/components/template/header/header.service';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css']
})
export class RegistroComponent {


  constructor(private headerService: HeaderService) {
    headerService.headerData = {
      title: 'Registro',
      icon: 'person_add_alt',
      routeUrl: '/registro',
    }
  }
  
}

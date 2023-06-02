import { Component } from '@angular/core';
import { HeaderService } from 'src/app/components/template/header/header.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent {

  constructor(private headerService: HeaderService) {
    headerService.headerData = {
      title: 'Login',
      icon: 'login',
      routeUrl: '/login',
    }
  }
    
}
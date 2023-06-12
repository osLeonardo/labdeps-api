import { HeaderService } from './../../components/template/header/header.service';
import { AuthService } from '../login/login.service';
import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  login: string;

  constructor(private headerService: HeaderService, private authService: AuthService) {

    headerService.headerData = {
      title: 'Início',
      icon: 'home',
      routeUrl: '',
    } 
  }

  ngOnInit(): void {
    const storedLogin = localStorage.getItem('login');
    this.login = storedLogin !== null ? storedLogin : '';
  }
}
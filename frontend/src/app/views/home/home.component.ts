
import { HttpClient } from "@angular/common/http";
import { HeaderService } from './../../components/template/header/header.service';
import { Component, OnInit } from '@angular/core';
import { AuthService } from '../login/login.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  private apiUrl = 'http://localhost:57679/api/v1';
  nome: string;
  perfil: number;

  constructor(
    private loginService: AuthService,
    private http: HttpClient,
    private headerService: HeaderService,
    ) {
      headerService.headerData = {
        title: 'Início',
        icon: 'home',
        routeUrl: '',
      } 
  }

  async ngOnInit(): Promise<void> {
    this.nome = await this.loginService.getNome();
  }
}
import { Observable } from 'rxjs';
import { HttpClient } from "@angular/common/http";
import { HeaderService } from './../../components/template/header/header.service';
import { Component, OnInit } from '@angular/core';
import { PerfilResponse } from 'src/app/components/administracao/models/usuarios.Model';
import { AuthService } from '../login/login.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  private apiUrl = 'http://localhost:57679/api/v1';
  nome: string;

  constructor(private loginService: AuthService, private headerService: HeaderService, private http: HttpClient) {

    headerService.headerData = {
      title: 'Início',
      icon: 'home',
      routeUrl: '',
    } 
  }

  async ngOnInit(): Promise<void> {
    this.nome = await this.loginService.getNomePerfil();
  }
}

import { AdministracaoService } from './../administracao.service';
import { Component, OnInit } from '@angular/core';
import { CreateUsuarios } from '../models/create-usuarios.Model';
import { HeaderService } from '../../template/header/header.service';

@Component({
  selector: 'app-usuario-read',
  templateUrl: './usuario-read.component.html',
  styleUrls: ['./usuario-read.component.css']
})
export class UsuarioReadComponent implements OnInit{
  

  usuario: CreateUsuarios[];
  displayedColumns = ["id", "login", "password", "perfilUsuario", "idPerfil", "opcoes"]

  constructor(private headerService: HeaderService, private AdministracaoService: AdministracaoService) {
    headerService.headerData = {
      title: 'Administração',
      icon: 'settings',
      routeUrl: '/administracao',
    }
  }

  ngOnInit(): void {
    this.AdministracaoService.read().subscribe(usuarios => {
      this.usuario = usuarios
      console.log(this.usuario);
      
    })
  }
}

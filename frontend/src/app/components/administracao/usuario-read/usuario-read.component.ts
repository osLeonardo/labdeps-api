
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

  getPerfilUsuarioString(perfilUsuario: number): string {
    switch (perfilUsuario) {
      case 0:
        return 'Automacao';
      case 1:
        return 'Administrador do Portal';
      case 2:
        return 'Administrador do Parceiro';
      case 3:
        return 'Usuario Gestor';
      case 4:
        return 'Usuario';
      case 5:
        return 'Gerente Comercial';
      case 6:
        return 'Comercial';
      case 7:
        return 'Suporte e Implantacao';
      case 8:
        return 'Financeiro';
      default:
        return 'Desconhecido';
    }
  }
  }

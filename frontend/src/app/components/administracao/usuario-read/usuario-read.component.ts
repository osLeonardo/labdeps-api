
import { AdministracaoService } from './../administracao.service';
import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { Usuarios } from '../models/usuarios.Model';
import { HeaderService } from '../../template/header/header.service';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';

@Component({
  selector: 'app-usuario-read',
  templateUrl: './usuario-read.component.html',
  styleUrls: ['./usuario-read.component.css']
})
export class UsuarioReadComponent implements AfterViewInit,OnInit{
  
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  usuario = new MatTableDataSource<Usuarios>();
  displayedColumns = ["id", "nome", "sobrenome", "login", "perfilUsuario", "ativo", "opcoes"]

  constructor(private headerService: HeaderService, private AdministracaoService: AdministracaoService) {
    headerService.headerData = {
      title: 'Administração',
      icon: 'settings',
      routeUrl: '/administracao',
    }
  }

  ngOnInit(): void {
    this.AdministracaoService.read().subscribe(usuarios => {
      this.usuario.data = usuarios;
    })
  }

  ngAfterViewInit(): void {
    this.usuario.paginator = this.paginator
    this.usuario.sort = this.sort;
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

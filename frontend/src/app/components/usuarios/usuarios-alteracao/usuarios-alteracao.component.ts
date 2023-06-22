import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Usuario } from 'src/app/components/usuarios/models/usuarios.model';
import { UsuariosService } from '../usuarios.service';
import { HeaderService } from '../../template/header/header.service';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-usuarios-alteracao',
  templateUrl: './usuarios-alteracao.component.html',
  styleUrls: ['./usuarios-alteracao.component.css']
})

export class UsuariosAlteracaoComponent implements OnInit {
  
  usuario: Usuario = {
    id: 0,
    nome: '',
    sobrenome: '',
    login: '',
    password: '',
    perfilUsuario: 0,
    ativo: true
  };

  constructor(
    public dialog: MatDialog,
    private headerService: HeaderService,
    private usuarioService: UsuariosService,
    private router: Router
    ) {
    headerService.headerData = {
      title: 'Usuário',
      icon: ' account_circle ',
      routeUrl: '/usuarios/:id',
    }
  }

  ngOnInit(): void {
    this.usuarioService.GetById().subscribe(Usuario => {
      this.usuario = Usuario;
    })
  }

  Cancelar(): void{
    this.router.navigate([`/usuarios/${this.usuario.id}`]);
  }

  Confirmar(): void{
    this.usuarioService.Update(this.usuario).subscribe(Usuario => {
      this.usuario = Usuario;
    })  
  }
}

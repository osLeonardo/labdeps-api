import { UpdateUsuario } from '../models/updateUsuario.model';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Usuario } from 'src/app/components/usuarios/models/usuarios.model';
import { UsuariosService } from '../usuarios.service';
import { HeaderService } from '../../template/header/header.service';
import { MatDialog } from '@angular/material/dialog';
import { GetPerfil } from '../models/getPerfil.model';
import { UpdatePerfil } from '../models/updatePerfil.model';

@Component({
  selector: 'app-usuarios-alteracao',
  templateUrl: './usuarios-alteracao.component.html',
  styleUrls: ['./usuarios-alteracao.component.css']
})

export class UsuariosAlteracaoComponent implements OnInit {
  
  usuario: Usuario = {
    id: 0,
    login: '',
    password: '',
    perfilUsuario: 0,
    idPerfil: 0,
    nome: '',
    ativo: true
  }; 

  usuarioUpdate: UpdateUsuario = { //user update request e response
    id: 0,
    login: "",
    password: "",
    perfilUsuario: 0,
  };
  
  perfil: UpdatePerfil = { //perfil update request e response
    id: 0,
    ativo: false,
    nome: "",
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
    this.usuarioService.GetById().subscribe(Usuarios => {
      this.usuario = Usuarios;
    })
  }

  Cancelar(): void{
    console.log('Alteração cancelada.');
    this.router.navigate([`/usuarios/${this.usuario.id}`]);
  }

  Confirmar(): void{
    console.log(this.usuario.id);
    console.log(this.usuario.login);
    console.log(this.usuario.nome);
    
    this.usuarioUpdate.id = this.usuario.id;
    this.usuarioUpdate.login = this.usuario.login;
    this.usuarioUpdate.password = this.usuario.password;
    this.usuarioUpdate.perfilUsuario = this.usuario.perfilUsuario;
    this.perfil.id = this.usuario.idPerfil;
    this.perfil.ativo = this.usuario.ativo;
    this.perfil.nome = this.usuario.nome;

    this.usuarioService.Update(this.usuarioUpdate).subscribe(Usuarios => {
      this.usuarioUpdate = Usuarios;

      this.usuarioService.UpdatePerfil(this.perfil).subscribe(Perfil => {
        this.perfil = Perfil;
        this.router.navigate([`/usuarios/${this.usuario.id}`]);
      })
    })  
  }
}

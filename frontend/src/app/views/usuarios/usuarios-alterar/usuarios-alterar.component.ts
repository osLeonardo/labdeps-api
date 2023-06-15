import { UsuarioUpdateComponent } from './../../../components/administracao/usuario-update/usuario-update.component';
import { Usuario } from 'src/app/components/usuarios/models/usuarios.model';
import { UsuariosAlteracaoComponent } from './../../../components/usuarios/usuarios-alteracao/usuarios-alteracao.component';
import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { HeaderService } from 'src/app/components/template/header/header.service';
import { UsuariosService } from 'src/app/components/usuarios/usuarios.service';
import { UsuariosComponent } from '../usuarios.component';

@Component({
  selector: 'app-usuarios-alterar',
  templateUrl: './usuarios-alterar.component.html',
  styleUrls: ['./usuarios-alterar.component.css']
})
export class UsuariosAlterarComponent{
  
  // usuario: Usuario;

  // route : Router;

  // constructor(
  //   public dialog: MatDialog,
  //   private headerService: HeaderService,
  //   private router: Router,
  //   private usuariosService: UsuariosService,
  //   ) {
  //     headerService.headerData = {
  //       title: 'Usuário',
  //       icon: ' account_circle ',
  //       routeUrl: '/usuariosAlterar',
  //     }
  // }

  // usuarioService: UsuariosService;

  // ngOnInit(): void {
  //   const perfil = 1;
  //   this.usuarioService.GetById().subscribe(Usuarios => {
  //     this.usuario = Usuarios;
  //     console.log('Dados do usuário (página alteração):', Usuarios)
  //   })  
  // }

  // Cancelar(): void{
  //   console.log('Alteração cancelada.');
  //   this.router.navigate(['/usuarios/:id']);
  // }

  // Confirmar(): void{
  //   //Update
  //   console.log(this.usuario.id);
  //   console.log(this.usuario.login);
  //   if (this.usuario != null)
  //   {
  //     this.usuariosService.Update(this.usuario).subscribe(Usuarios => {
  //       this.usuario = Usuarios;
  //       this.router.navigate([`/usuarios/${this.usuario.id}`]);
  //     })  
  //     console.log('Alterações confirmadas com sucesso!', this.usuario.login);
  //   }
  //   else
  //   {
  //     console.log('Alteração vazia');
  //   }
  // }
}

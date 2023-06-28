import { Component } from '@angular/core';
import { CreateUsuarios, Usuarios } from '../models/usuarios.Model';
import { AdministracaoService } from '../administracao.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-usuario-create',
  templateUrl: './usuario-create.component.html',
  styleUrls: ['./usuario-create.component.css']
})
export class UsuarioCreateComponent {

  usuario: CreateUsuarios = {
    nome: '',
    sobrenome: '',
    login: '',
    password: '',
    perfilUsuario: 0
  }
  user: Usuarios;

  constructor(private AdministracaoService: AdministracaoService, private router: Router,) {}

  CadastrarUsuario(): void {

    this.AdministracaoService.Cadastrar(this.usuario).subscribe(user => {
      this.user = user;
      this.router.navigate(['/administracao']);
     })
  }
  cancelar(): void {
    this.router.navigate(['/administracao']);
  }
}

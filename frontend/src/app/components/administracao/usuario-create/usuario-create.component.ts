
import { Component } from '@angular/core';
import { CreateUsuarios, Perfil } from '../models/create-usuarios.Model';
import { AdministracaoService } from '../administracao.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-usuario-create',
  templateUrl: './usuario-create.component.html',
  styleUrls: ['./usuario-create.component.css']
})
export class UsuarioCreateComponent {

  usuario: CreateUsuarios = {
    login: 'bruno',
    password: '123',
    perfilUsuario: 0,
    perfil: {
      id: 0
    }
  }

  constructor(private AdministracaoService: AdministracaoService, private router: Router,) {}

  CadastrarUsuario(): void {
    this.AdministracaoService.Cadastrar(this.usuario).subscribe(() => {
      this.router.navigate(['/administracao'])
     }) 
  }
  cancelar(): void {
    this.router.navigate(['/administracao'])
  }
}

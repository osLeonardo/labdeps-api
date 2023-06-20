import { Component } from '@angular/core';
import { CreateUsuarios } from '../models/usuarios.Model';
import { AdministracaoService } from '../administracao.service';
import { Router } from '@angular/router';
import { CreatePerfil } from '../models/perfil.Model';

@Component({
  selector: 'app-usuario-create',
  templateUrl: './usuario-create.component.html',
  styleUrls: ['./usuario-create.component.css']
})
export class UsuarioCreateComponent {

  usuario: CreateUsuarios = {
    id: 0,
    login: '',
    password: '',
    perfilUsuario: 0,
    perfil: {
      id: 0,
    }
  }

  perfil: CreatePerfil= {
    nome: '',
    ordem: 1,
    id: 0,
    ativo: true
  }

  constructor(private AdministracaoService: AdministracaoService, private router: Router,) {}

  CadastrarUsuario(): void {

    this.AdministracaoService.cadastrarperfil(this.perfil).subscribe((perfil) => {
      this.usuario.perfil.id = perfil.id
      this.AdministracaoService.Cadastrar(this.usuario).subscribe(() => {

        this.router.navigate(['/administracao'])
       }) 
    })


  }
  cancelar(): void {
    this.router.navigate(['/administracao'])
  }
}

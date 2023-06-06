import { Component } from '@angular/core';
import { CreateUsuarios } from '../models/create-usuarios.Model';

@Component({
  selector: 'app-usuario-read',
  templateUrl: './usuario-read.component.html',
  styleUrls: ['./usuario-read.component.css']
})
export class UsuarioReadComponent {

  usuario = uusuarios;
  displayedColumns = ["login", "password", "perfilUsuario", "perfil.id", "opcoes"]

}

const uusuarios:  CreateUsuarios[] = [
{
  login: "string",
  password: "string",
  perfilUsuario: 0,
  perfil: {
    id: 0
  }
}
]
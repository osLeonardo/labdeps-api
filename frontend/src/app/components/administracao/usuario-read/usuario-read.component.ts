import { Component } from '@angular/core';

@Component({
  selector: 'app-usuario-read',
  templateUrl: './usuario-read.component.html',
  styleUrls: ['./usuario-read.component.css']
})
export class UsuarioReadComponent {

  usuario = uusuarios;
  displayedColumns = ["nome", "dataNascimento", "senha", "opcoes"]

}

export interface usuario{
    nome: string;
    dataNascimento: string;
    senha: string;
} 

const uusuarios:  usuario[] = [
  {
    nome: "bruno",
    dataNascimento: "14/02/2002",
    senha: "senha"
  }
]
  

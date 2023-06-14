import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { MatTableDataSource } from '@angular/material/table';
import { Usuario } from 'src/app/components/usuarios/models/usuarios.model';
import { ActivatedRoute } from '@angular/router';
import { UsuariosService } from '../usuarios.service';

@Component({
  selector: 'app-usuarios-alteracao',
  templateUrl: './usuarios-alteracao.component.html',
  styleUrls: ['./usuarios-alteracao.component.css']
})

export class UsuariosAlteracaoComponent implements OnInit {
  
  usuario: Usuario;

  constructor(private usuarioService: UsuariosService, private route: ActivatedRoute) {}

  ngOnInit(): void {
    const perfil = 1;
    this.usuarioService.GetById(perfil).subscribe(Usuarios => {
      this.usuario = Usuarios;
      console.log('Dados do usuário (página alteração):', Usuarios)
    })
  }
}

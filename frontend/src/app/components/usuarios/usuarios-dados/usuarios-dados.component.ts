import { Component, OnInit } from '@angular/core';
import { Usuario } from '../models/usuarios.model';
import { UsuariosService } from '../usuarios.service';
import { ActivatedRoute, Router } from '@angular/router';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-usuarios-dados',
  templateUrl: './usuarios-dados.component.html',
  styleUrls: ['./usuarios-dados.component.css']
})
export class UsuariosDadosComponent implements OnInit{
  usuarioDataSource: MatTableDataSource<Usuario>;
  usuario: Usuario[];
  displayedColumns = ["nome", "sobrenome", "login", "password"]

  constructor(private usuarioService: UsuariosService, private route: ActivatedRoute) {}
  ngOnInit(): void {
    this.usuarioService.GetById().subscribe(Usuarios => {
      this.usuario = [Usuarios];
      this.usuarioDataSource = new MatTableDataSource<Usuario>(this.usuario);
    })
  }
}
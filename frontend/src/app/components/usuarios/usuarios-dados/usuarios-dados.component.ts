import { Component, OnInit } from '@angular/core';
import { Perfil, Usuario } from '../models/usuarios.model';
import { UsuariosService } from '../usuarios.service';
import { ActivatedRoute } from '@angular/router';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-usuarios-dados',
  templateUrl: './usuarios-dados.component.html',
  styleUrls: ['./usuarios-dados.component.css']
})
export class UsuariosDadosComponent implements OnInit{

  usuarioDataSource: MatTableDataSource<Usuario>;
  usuario: Usuario[];
  displayedColumns = ["id", "login", "password", "perfilUsuario", "idPerfil"]

  constructor(private usuarioService: UsuariosService, private route: ActivatedRoute) {}

  ngOnInit(): void {
    // const perfil = parseInt(`${this.route.snapshot.paramMap.get('perfil')}`);
    const perfil = 5;
    this.usuarioService.GetById().subscribe(Usuarios => {
      this.usuario = [Usuarios];
      console.log('Dados do usuário (página dados):', Usuarios)
      this.usuarioDataSource = new MatTableDataSource<Usuario>(this.usuario);
    })
  }
  
}
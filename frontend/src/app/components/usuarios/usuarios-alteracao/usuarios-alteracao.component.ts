import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { MatTableDataSource } from '@angular/material/table';
import { Usuario } from 'src/app/components/usuarios/models/usuarios.model';
import { ActivatedRoute } from '@angular/router';
import { UsuariosService } from '../usuarios.service';
import { HeaderService } from '../../template/header/header.service';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-usuarios-alteracao',
  templateUrl: './usuarios-alteracao.component.html',
  styleUrls: ['./usuarios-alteracao.component.css']
})

export class UsuariosAlteracaoComponent implements OnInit {
  
  usuario: Usuario;

  constructor(
    public dialog: MatDialog,
    private headerService: HeaderService,
    private usuarioService: UsuariosService,
    private route: ActivatedRoute,
    private router: Router
    ) {
    headerService.headerData = {
      title: 'Usuário',
      icon: ' account_circle ',
      routeUrl: '/usuarios/:id',
    }
  }

  usuariosService: UsuariosService;

  ngOnInit(): void {
    const perfil = 1;
    this.usuarioService.GetById().subscribe(Usuarios => {
      this.usuario = Usuarios;
      console.log('Dados do usuário (página alteração):', Usuarios)
    })
  }

  Cancelar(): void{
    console.log('Alteração cancelada.');
    this.router.navigate(['/usuarios/:id']);
  }

  Confirmar(): void{
    //Update
    console.log(this.usuario.id);
    console.log(this.usuario.login);
    if (this.usuario != null)
    {
      this.usuariosService.Update(this.usuario).subscribe();/*Usuarios => {*/
        // this.usuario = Usuarios;
        this.router.navigate([`/usuarios/${this.usuario.id}`]);
      // })  
      console.log('Alterações confirmadas com sucesso!', this.usuario.login);
    }
    else
    {
      console.log('Alteração vazia');
    }
  }
}

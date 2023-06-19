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
  
}

import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { HeaderService } from 'src/app/components/template/header/header.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-usuarios',
  templateUrl: './usuarios.component.html',
  styleUrls: ['./usuarios.component.css']
})
export class UsuariosComponent {
  constructor(public dialog: MatDialog, private headerService: HeaderService, private router: Router) {
    headerService.headerData = {
      title: 'Usuário',
      icon: ' account_circle ',
      routeUrl: '/usuarios/1',
      
    }
  }

  button: true;

  Alterar(): void{
    this.router.navigate(['usuarios/1/usuariosAlterar'])
  }
}
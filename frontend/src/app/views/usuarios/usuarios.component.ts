import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { HeaderService } from 'src/app/components/template/header/header.service';
import { Router } from '@angular/router';
import { AuthService } from '../login/login.service';

@Component({
  selector: 'app-usuarios',
  templateUrl: './usuarios.component.html',
  styleUrls: ['./usuarios.component.css']
})
export class UsuariosComponent {
  constructor(
    public dialog: MatDialog,
    private headerService: HeaderService,
    private router: Router,
    private authService: AuthService) {
    headerService.headerData = {
      title: 'Usuário',
      icon: ' account_circle ',
      routeUrl: '/usuarios/:id',
      
    }
  }

  Alterar(): void{
    this.router.navigate([`usuarios/${this.authService.getUserId()}/usuariosAlterar`]);
  }
}
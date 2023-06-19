import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from './login.service';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { LoginDialogComponent } from './dialog-login.component';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent {
  username: string;
  password: string;
  errorMessage: string;

  constructor(
    private authService: AuthService,
    private dialog: MatDialog,
    private router: Router,
  ) {}

  login(): void {
    this.authService.verifyLogin(this.username, this.password).subscribe(
      response => {
        if (response.idPerfil) {
          this.authService.setAuthenticated;
          this.authService.setToken(response.token);
          this.authService.setUserId(response.id);
          this.authService.setIdPerfil(response.idPerfil);
          this.authService.setUserPerfil(response.perfilUsuario);          
          this.router.navigate(['']);
        }
      }, error => {
        this.errorMessage = 'Usuário ou Senha Inválidos. Tente Novamente!';
        this.openDialog();
      } 
    );
  }

  openDialog(): void {
    const dialogRef = this.dialog.open(LoginDialogComponent, {
      width: '300px',
      data: { errorMessage: this.errorMessage }
    });
  }
}
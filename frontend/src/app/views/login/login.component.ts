import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from './login.service';
import { MatSnackBar } from '@angular/material/snack-bar';

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
    private snackBar: MatSnackBar,
    private router: Router,
  ) {}

  esqueceu(): void {
    this.snackBar.open("Favor, Contate o Suporte Para Recuperar a Senha.", "Fechar", {
      panelClass: 'snackbar-error',
      horizontalPosition: 'right',
      verticalPosition: 'top',
      duration: 5000,
    })
  }

  login(): void {
    this.authService.verifyLogin(this.username, this.password).subscribe(
      response => {
        if (response.token) {
          this.authService.setAuthenticated;
          this.authService.setToken(response.token);
          this.authService.setUserId(response.id);
          this.authService.setUserPerfil(response.perfilUsuario);          
          this.router.navigate(['']);
          this.openSuccessSnackBar();
        }
      }, error => {
        this.openFailureSnackBar(); 
      } 
    );
  }

  openSuccessSnackBar(): void {
    this.snackBar.open("Login Realizado com Sucesso!", "Fechar", {
      panelClass: 'snackbar-success',
      horizontalPosition: 'right',
      verticalPosition: 'top',
      duration: 5000,
    });
  }

  openFailureSnackBar(): void {
    this.snackBar.open("Falha ao Efetuar Login!", "Fechar", {
      panelClass: 'snackbar-error',
      horizontalPosition: 'right',
      verticalPosition: 'top',
      duration: 5000,
    });
  }
}
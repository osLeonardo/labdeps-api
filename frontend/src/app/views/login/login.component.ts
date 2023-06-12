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
      (response) => {
        if (response.login && response.token) {
          this.authService.setToken(response.token);
          this.router.navigate(['']);
        } else {
          this.errorMessage = 'Invalid username or password. Please try again.';
          this.openDialog();
        }
      }
    );
  }

  openDialog(): void {
    const dialogRef = this.dialog.open(LoginDialogComponent, {
      width: '250px',
      data: { errorMessage: this.errorMessage }
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
      // You can perform additional actions after the dialog is closed if needed.
    });
  }
}
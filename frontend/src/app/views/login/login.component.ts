import { verifyLogin } from './login.model';
import { Component } from '@angular/core';
import { HeaderService } from 'src/app/components/template/header/header.service';
import { LoginService } from './login.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent {

  username: string;
  password: string;
  verified: verifyLogin[] = [];

  constructor(
    private router: Router,
    private loginService: LoginService,
    private headerService: HeaderService) {    
      headerService.headerData = {
        title: 'Entrar',
        icon: 'login',
        routeUrl: '/login',
      }
    }

  verifyCredentials(username: string, password: string) {
    this.loginService.PostLoginVerification(username, password).subscribe(
      () => {
        console.log("User is logged in");        
        this.router.navigate(['']);
      }
    )
  }
}
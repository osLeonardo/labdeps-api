import { Component } from '@angular/core';
import { AuthService } from './views/login/login.service';

@Component({
  selector: 'app-root',
  templateUrl : 'app.component.html'
})
export class AppComponent {

  title = 'frontend';
  token: string | null;

  constructor(public authService: AuthService) { }

  get isAuthenticated(): boolean {
    return this.authService.isAuthenticated();
  }

  ngOnInit() {
    this.token = this.authService.getToken();
  }
}
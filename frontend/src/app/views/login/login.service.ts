import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { Observable } from "rxjs";
import { tap } from "rxjs/operators";

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private apiUrl = 'http://localhost:57679/api/v1/userLogin';
  private token: string;

  constructor(private http: HttpClient, private router: Router) { }

  setToken(token: string): void {
    this.token = token;
    localStorage.setItem('token', token);
  }

  getToken(): string {
    return this.token;
  }

  isAuthenticated(): boolean {
    return !!this.token;
  }

  logout(): void {
    this.token = "";
    this.router.navigate(['/login']);
  }

  verifyLogin(login: string, password: string): Observable<any> {
    const url = `${this.apiUrl}/verifyLogin/${login}/${password}`;
    const body = { login, password };
    return this.http.post<any>(url, body).pipe(
      tap(data => {
        this.setAuthenticated(data.authenticated);
      })
    );
  }

  private setAuthenticated(authenticated: boolean): void {
    if (authenticated) {
      localStorage.setItem('authenticated', 'true');
    } else {
      localStorage.removeItem('authenticated');
    }
  }
}
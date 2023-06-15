import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { Observable } from "rxjs";
import { CreateUsuarios, PerfilResponse } from "src/app/components/administracao/models/create-usuarios.Model";
import { VerifyRequest, verifyLogin } from "./login.model";

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private apiUrl = 'http://localhost:57679/api/v1';
  private token: string;
  private userId: number;
  private IdPerfil: number;
  private userPerfil: number;

  constructor(private http: HttpClient, private router: Router) { }

  setIdPerfil(IdPerfil: number): void {
    this.IdPerfil = IdPerfil;
    sessionStorage.setItem('idPerfil', JSON.stringify(IdPerfil));
  }

  getNomePerfil(): Promise<string> {
    const url = `${this.apiUrl}/perfil/${this.IdPerfil}`;
  
    return new Promise<string>((resolve, reject) => {
      this.http.get<PerfilResponse>(url).subscribe(
        (perfil) => {
          const nome = perfil.nome;
          resolve(nome);
        },
        (error) => {
          reject(error);
        }
      );
    });
  }
  
  setUserPerfil(userPerfil: number): void {
    this.userPerfil = userPerfil;
    sessionStorage.setItem('userPerfil', JSON.stringify(userPerfil));
    console.log(this.userPerfil);
    console.log(userPerfil);
    console.log(sessionStorage.getItem('userPerfil'));
  }

  getUserPerfil(): number {
    return this.userPerfil;
  }

  setUserId(userId: number): void {
    this.userId = userId;
    localStorage.setItem('userId', JSON.stringify(userId));
  }

  getUserId(): number {
    return this.userId;
  }

  setToken(token: string): void {
    this.token = token;
    localStorage.setItem('token', JSON.stringify(token));
  }

  getToken(): string {
    return this.token;
  }

  isAuthenticated(): boolean {
    return !!this.token;
  }

  logout(): void {
    this.token = "";
    localStorage.removeItem('authenticated');
    this.router.navigate(['/login']);
  }

  verifyLogin(login: string, password: string): Observable<verifyLogin> {
    const url = `${this.apiUrl}/userLogin/verifyLogin`;
    const body: VerifyRequest = {
      login: login,
      password: password,
    }
    return this.http.post<verifyLogin>(url, body);
  }

  public setAuthenticated(authenticated: boolean): void {
    if (authenticated) {
      localStorage.setItem('authenticated', 'true');
    } else {
      localStorage.removeItem('authenticated');
    }
  }
}
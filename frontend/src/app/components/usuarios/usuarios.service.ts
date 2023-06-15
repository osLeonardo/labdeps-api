import { Observable } from 'rxjs/internal/Observable';
import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Perfil, Usuario } from './models/usuarios.model';
import { AuthService } from 'src/app/views/login/login.service';
import { UsuariosAlteracaoComponent } from './usuarios-alteracao/usuarios-alteracao.component';

@Injectable({ providedIn: 'root' })

export class UsuariosService {
    baseUrl = "http://localhost:57679/api/v1";

    constructor(private http: HttpClient, private service: AuthService) { }

    GetById(): Observable<Usuario>{
        const urlUserGet = `${this.baseUrl}/userLogin/${this.service.getUserId()}`;
        return this.http.get<Usuario>(urlUserGet);
    }

    Update(usuario: Usuario): Observable<Usuario>{
        const urlUserUpdate = `${this.baseUrl}/userLogin`;
        return this.http.put<Usuario>(urlUserUpdate, usuario);
    }
}
import { Observable } from 'rxjs/internal/Observable';
import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Perfil, Usuario } from './models/usuarios.model';

@Injectable({ providedIn: 'root' })

export class UsuariosService {
    baseUrl = "http://localhost:57679/api/v1";

    constructor(private http: HttpClient) { }

    GetById(perfil: number): Observable<Usuario>{
        const urlUserGet = `${this.baseUrl}/userLogin/${perfil}`;
        return this.http.get<Usuario>(urlUserGet);
    }

    Update(usuario: Usuario): Observable<Usuario>{
        const urlUserUpdate = `${this.baseUrl}/userLogin`;
        return this.http.put<Usuario>(urlUserUpdate, usuario);
    }
}
import { Observable } from 'rxjs/internal/Observable';
import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Usuario } from './models/usuarios.model';
import { AuthService } from 'src/app/views/login/login.service';
import { UsuariosAlteracaoComponent } from './usuarios-alteracao/usuarios-alteracao.component';
import { UpdateUsuario } from './models/updateUsuario.model';
import { GetPerfil } from './models/getPerfil.model';
import { UpdatePerfil } from './models/updatePerfil.model';

@Injectable({ providedIn: 'root' })

export class UsuariosService {
    baseUrl = "http://localhost:57679/api/v1";

    constructor(private http: HttpClient, private service: AuthService) { }

    GetById(): Observable<Usuario>{
        const urlUserGet = `${this.baseUrl}/userLogin/${this.service.getUserId()}`;
        return this.http.get<Usuario>(urlUserGet);
    }

    Update(usuario: UpdateUsuario): Observable<UpdateUsuario>{
        const urlUserUpdate = `${this.baseUrl}/userLogin`;
        return this.http.put<UpdateUsuario>(urlUserUpdate, usuario);
    }

    GetPerfilById(id: number): Observable<GetPerfil>{
        const urlGetPerfil = `${this.baseUrl}/perfil/${id}`;
        return this.http.get<GetPerfil>(urlGetPerfil);
    }

    UpdatePerfil(perfilAlteracao: UpdatePerfil): Observable<UpdatePerfil>{
        const urlPerfilUpdate = `${this.baseUrl}/perfil`;
        return this.http.put<UpdatePerfil>(urlPerfilUpdate, perfilAlteracao);
    }
}
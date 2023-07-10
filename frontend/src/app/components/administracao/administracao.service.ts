
import { Observable } from 'rxjs/internal/Observable';
import { HttpClient } from '@angular/common/http';
import { Injectable, OnInit } from '@angular/core';
import { CreateUsuarios, Usuarios } from './models/usuarios.Model';


@Injectable({
  providedIn: 'root'
})
export class AdministracaoService {

  baseUrl = "http://localhost:57679/api/v1/";


  constructor(private http: HttpClient) { }

  Cadastrar(usuario: CreateUsuarios): Observable<Usuarios>{ 
    const urlCadastar = `${this.baseUrl}userLogin`
    return this.http.post<Usuarios>(urlCadastar, usuario)
  }

  read(): Observable<Usuarios[]>{
    const urlRead = `${this.baseUrl}userLogin`
    return this.http.get<Usuarios[]>(urlRead)
  }

  readById(id: number): Observable<Usuarios> {
    const url = `${this.baseUrl}userLogin/${id}`
    return this.http.get<Usuarios>(url)
  }

  atualizar(usuario: Usuarios): Observable<Usuarios>{
    const urlAtualizar = `${this.baseUrl}userLogin`
    console.log(usuario)
    return this.http.put<Usuarios>(urlAtualizar, usuario)
  }

}
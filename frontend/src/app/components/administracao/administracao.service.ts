import { Observable } from 'rxjs/internal/Observable';
import { HttpClient } from '@angular/common/http';
import { Injectable, OnInit } from '@angular/core';
import { CreateUsuarios } from './models/create-usuarios.Model';

@Injectable({
  providedIn: 'root'
})
export class AdministracaoService {

  baseUrl = "http://localhost:57679/api/v1/";

  constructor(private http: HttpClient) { }

  Cadastrar(usuario: CreateUsuarios): Observable<CreateUsuarios>{ 
    const urlCadastar = `${this.baseUrl}userLogin`
    return this.http.post<CreateUsuarios>(urlCadastar, usuario)
  }

  read(): Observable<CreateUsuarios[]>{
    const urlRead = `${this.baseUrl}userLogin`
    return this.http.get<CreateUsuarios[]>(urlRead)
  }

  readById(id: number): Observable<CreateUsuarios> {
    const url = `${this.baseUrl}userLogin/${id}`
    return this.http.get<CreateUsuarios>(url)
  }

  atualizar(usuario: CreateUsuarios): Observable<CreateUsuarios>{
    const urlAtualizar = `${this.baseUrl}userLogin`
    console.log(usuario)
    return this.http.put<CreateUsuarios>(urlAtualizar, usuario)
  }
}
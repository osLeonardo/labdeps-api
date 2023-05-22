import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Remuneracao } from './models/remuneracao.model';
import { HttpClient } from '@angular/common/http';
import { bolsaFamilia } from './model/bolsaFamilia.Model';
import { peti } from './model/peti.Model';

@Injectable({
  providedIn: 'root'
})
export class ConsultasService {

  baseUrl = "http://localhost:57679/api/v1/"; //Rodar o backend na opção 'PortalTransparenciaDeps'
  pagina = 1; //valor constante para página

  constructor(private http: HttpClient) { }

  
  GetBolsaFamiliaByCpf(dataCompetencia: number, codigo: string): Observable<bolsaFamilia[]> {
    const UrlBF = `${this.baseUrl}bolsaFamilia/${dataCompetencia}/${dataCompetencia}/${codigo}/${this.pagina}`;
    return this.http.get<bolsaFamilia[]>(UrlBF)
  }
  
  GetBpcByCpf(codigo: string){

  }
  GetPetiByCpf(codigo: string): Observable<peti[]> {
    const UrlPeti = `${this.baseUrl}peti/${codigo}/${this.pagina}`;
    return this.http.get<peti[]>(UrlPeti)

  }
  GetPepByCpf(codigo: string){

  }
  GetRemuneracaoByCpf(codigo: string, dataCompetencia: number): Observable<Remuneracao[]> {
    const url = `${this.baseUrl}/Remuneracao/${codigo}/${dataCompetencia}/${this.pagina}`;  
    return this.http.get<Remuneracao[]>(url)
  }
  GetCepimByCnpj(codigo: string){
    
  }
  GetCnepByCnpj(codigo: string){
    
  }
  GetLenienciaByCnpj(codigo: string){
    
  }  
}

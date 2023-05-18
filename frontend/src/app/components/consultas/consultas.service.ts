import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { LenienciaByCnpj } from './model/lenienciaByCnpj.Model';
import { Observable } from 'rxjs';
import { CepimByCnpj } from './model/cepimByCnpj.Model';

@Injectable({
  providedIn: 'root'
})
export class ConsultasService {

  baseUrl = "http://localhost:57679/api/v1/"; //Rodar o backend na opção 'PortalTransparenciaDeps'
  pagina = 1; //valor constante para página

  constructor(private http: HttpClient) { }

  
  GetBolsaFamiliaByCpf(dataCompetencia: number, codigo: string){
    //Na url de requisição atribuir a 'dataReferencia' como igual a 'dataCompetencia'
    //Exemplo: bolsaFamilia/{dataCompetencia}/{dataCompetencia}/{codigo}/{pagina} 

  }
  GetBpcByCpf(codigo: string){

  }
  GetPetiByCpf(codigo: string){

  }
  GetPepByCpf(codigo: string){

  }
  GetRemuneracaoByCpf(codigo: string, dataCompetencia: number){
    
  }
  GetCepimByCnpj(codigo: string): Observable<CepimByCnpj[]>{
    var url = `${this.baseUrl}Cepim/${codigo}/${this.pagina}`
    return this.http.get<CepimByCnpj[]>(url)
  }
  GetCnepByCnpj(codigo: string){
    
  }
  GetLenienciaByCnpj(codigo: string): Observable<LenienciaByCnpj[]>{
  var url = `${this.baseUrl}Leniencia/${codigo}/${this.pagina}`
  return this.http.get<LenienciaByCnpj[]>(url)
  }  
}

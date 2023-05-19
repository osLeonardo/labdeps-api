import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { bpc } from './models/bpc.Model';
import { pep } from './models/pep.Model';

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
  GetBpcByCpf(codigo: string): Observable<bpc[]>{
    const urlBpc = `${this.baseUrl}Bpc/${codigo}/${this.pagina}`;
    return this.http.get<bpc[]>(urlBpc)
  }
  GetPetiByCpf(codigo: string){

  }
  GetPepByCpf(codigo: string): Observable<pep[]>{
    const urlPep = `${this.baseUrl}Pep/${codigo}/${this.pagina}`;
    return this.http.get<pep[]>(urlPep)
  }
  GetRemuneracaoByCpf(codigo: string, dataCompetencia: number){
    
  }
  GetCepimByCnpj(codigo: string){
    
  }
  GetCnepByCnpj(codigo: string){
    
  }
  GetLenienciaByCnpj(codigo: string){
    
  }  
}

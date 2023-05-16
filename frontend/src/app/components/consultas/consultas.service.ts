import { Injectable } from '@angular/core';
import { Cnep } from './models/cnep.model';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

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
  GetCepimByCnpj(codigo: string){
    
  }
  GetCnepByCnpj(codigo: string): Observable<Cnep[]>{
    const url = `${this.baseUrl}Cnep/${codigo}/${this.pagina}`;
    return this.http.get<Cnep[]>(url);
  }
  GetLenienciaByCnpj(codigo: string){
    
  }  
}

import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ConsultasService {

  baseUrl = "http://localhost:57679/api/v1/"; //Rodar o backend na opção 'PortalTransparenciaDeps'
  pagina = 1; //valor constante para página

  constructor() { }

  
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
  GetCnepByCnpj(codigo: string){
    
  }
  GetLenienciaByCnpj(codigo: string){
    
  }  
}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Cnep } from './models/cnep.Model';
import { LenienciaByCnpj } from './models/lenienciaByCnpj.Model';
import { CepimByCnpj } from './models/cepimByCnpj.Model';
import { bpc } from './models/bpc.Model';
import { pep } from './models/pep.Model';
import { Observable } from 'rxjs/internal/Observable';
import { Remuneracao } from './models/remuneracao.Model';
import { bolsaFamilia } from './models/bolsaFamilia.Model';
import { peti } from './models/peti.Model';
import { Historico, HistoricoRequest } from './models/historico.Model';
import { AuthService } from 'src/app/views/login/login.service';

@Injectable({
  providedIn: 'root'
})
export class ConsultasService {

  baseUrl = "http://localhost:57679/api/v1/"; //Rodar o backend na opção 'PortalTransparenciaDeps'
  pagina = 1; //valor constante para página

  constructor(private http: HttpClient, private authService: AuthService) { }

  CreateHistorico(consulta: string, codigo: string, dataReferencia: Date, intervalo: string): Observable<Historico>{
    const body: HistoricoRequest = {
      user:{
        id: this.authService.getUserId()
      },
      dataConsulta: new Date(),
      tipoConsulta: consulta,
      codigo: codigo,
      dataReferencia: dataReferencia,
      intervalo: intervalo
    }
    const url = `${this.baseUrl}historico`;
    return this.http.post<Historico>(url,body);
  }
  GetListHistorico(): Observable<Historico[]>{
    const url = `${this.baseUrl}historico`;
    return this.http.get<Historico[]>(url);
  }
  GetHistoricoById(id: number): Observable<Historico>{
    const url = `${this.baseUrl}historico/${id}`;
    return this.http.get<Historico>(url);
  }


  GetBolsaFamiliaByCpf(dataCompetencia: number, codigo: string): Observable<bolsaFamilia[]> {
    const UrlBF = `${this.baseUrl}bolsaFamilia/${dataCompetencia}/${dataCompetencia}/${codigo}/${this.pagina}`;
    return this.http.get<bolsaFamilia[]>(UrlBF)
  }
  GetBpcByCpf(codigo: string): Observable<bpc[]>{
    const urlBpc = `${this.baseUrl}Bpc/${codigo}/${this.pagina}`;
    return this.http.get<bpc[]>(urlBpc)
  }
  GetPetiByCpf(codigo: string): Observable<peti[]> {
    const UrlPeti = `${this.baseUrl}peti/${codigo}/${this.pagina}`;
    return this.http.get<peti[]>(UrlPeti)

  }
  GetPepByCpf(codigo: string): Observable<pep[]>{
    const urlPep = `${this.baseUrl}Pep/${codigo}/${this.pagina}`;
    return this.http.get<pep[]>(urlPep)
  }
  GetRemuneracaoByCpf(codigo: string, dataCompetencia: number): Observable<Remuneracao[]> {
    const url = `${this.baseUrl}Remuneracao/${codigo}/${dataCompetencia}/${this.pagina}`;  
    return this.http.get<Remuneracao[]>(url)
  }
  GetCepimByCnpj(codigo: string): Observable<CepimByCnpj[]>{
    var url = `${this.baseUrl}Cepim/${codigo}/${this.pagina}`
    return this.http.get<CepimByCnpj[]>(url)
  }
  GetCnepByCnpj(codigo: string): Observable<Cnep[]>{
    const url = `${this.baseUrl}Cnep/${codigo}/${this.pagina}`;
    return this.http.get<Cnep[]>(url);
  }
  GetLenienciaByCnpj(codigo: string): Observable<LenienciaByCnpj[]>{
  var url = `${this.baseUrl}Leniencia/${codigo}/${this.pagina}`
  return this.http.get<LenienciaByCnpj[]>(url)
  }  
}

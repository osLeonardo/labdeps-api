import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Historico, HistoricoRequest } from './models/historico.Model';
import { AuthService } from 'src/app/views/login/login.service';

@Injectable({
  providedIn: 'root'
})
export class ConsultasService {

  baseUrl = "http://localhost:57679/api/v1/"; //Rodar o backend na opção 'PortalTransparenciaDeps'

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
  GetListHistorico(idUser: number): Observable<Historico[]>{
    const url = `${this.baseUrl}historico/user/${idUser}`;
    return this.http.get<Historico[]>(url);
  }
  GetHistoricoById(id: number): Observable<Historico>{
    const url = `${this.baseUrl}historico/${id}`;
    return this.http.get<Historico>(url);
  }  
}

export interface Historico{
    id: number;
    nome?: string;
    dataConsulta: string;
    tipoConsulta: string;
    codigo: string;
    dataReferencia: string;
    intervalo: string;
}

export interface HistoricoRequest {
    user: User;
    dataConsulta: Date;
    tipoConsulta: string;
    codigo: string;
    dataReferencia: Date;
    intervalo: string;
  }
  
  export interface User {
    id: number;
  }
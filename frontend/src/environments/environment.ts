import { ApplicationConfig } from "@angular/core";
import { provideServerRendering } from "@angular/platform-server";
import { provideRouter } from "@angular/router";
import { Routes } from '@angular/router';
import { AppRoutingModule, routes } from './../app/app-routing.module';
import { ActivatedRoute } from '@angular/router';
//ng server
//Esse arquivo é usado como um fallback padrão para qualquer ambiente que não seja de produção.
//Ele deve conter configurações que são comuns a todos os ambientes não relacionados à produção.
//Por exemplo, se você tiver outros ambientes, como staging, teste, etc., que não são ambientes de produção, esses ambientes podem usar o arquivo "environment.ts" como base e fazer substituições ou adições específicas em seus próprios arquivos de ambiente.;


export const environment = {
    production: true,
    prjectName: 'LABDEPS-DEMO',
    text:'Ambiente de produção',
    apiBaseUrl: 'http://sua-api.com',
    apiKey: 'sua-chave-de-api',
    serverConfig: {
      providers: [provideRouter(routes)]
    },
  };
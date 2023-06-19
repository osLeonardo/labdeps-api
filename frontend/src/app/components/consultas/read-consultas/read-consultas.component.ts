import { AuthService } from './../../../views/login/login.service';
import { ConsultasService } from './../consultas.service';
import { AfterViewInit, Component, Inject, LOCALE_ID, OnInit, ViewChild, inject } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { Historico } from '../models/historico.Model';
import { Router } from '@angular/router';
import { formatDate } from '@angular/common';

@Component({
  selector: 'app-read-consultas',
  templateUrl: './read-consultas.component.html',
  styleUrls: ['./read-consultas.component.css']
})
export class ReadConsultasComponent implements AfterViewInit, OnInit{

  @ViewChild(MatPaginator) paginator: MatPaginator;

  historico = new MatTableDataSource<Historico>();
  consulta: Historico;
  displayedColumns: string[] = 
  [
    'user',
    'dataCons', 
    'tipo', 
    'codigo', 
    'dataRef', 
    'intervalo',
    'actions'
  ];
  constructor(private consultasService: ConsultasService, private authService: AuthService, private router: Router, @Inject(LOCALE_ID) private locale: string){ }

  ngOnInit(): void {
    let idUser: number = this.authService.getUserId();
    this.consultasService.GetListHistorico(idUser).subscribe(historico => {
      for(let element of historico){
        element.tipoConsulta = element.tipoConsulta.toUpperCase();
        element.intervalo = `${element.intervalo} meses`;
        element.dataConsulta = formatDate(new Date(element.dataConsulta),'dd/MM/yyyy', this.locale);
        element.dataReferencia = formatDate(new Date(element.dataReferencia),'dd/MM/yyyy', this.locale);
      }
      this.historico.data = historico;
    })
  }
  
  ngAfterViewInit(): void {
    this.historico.paginator = this.paginator
  }

  Buscar(id: number): void{
    this.consultasService.GetHistoricoById(id).subscribe(historico => { 
      this.consulta = historico;
      this.consulta.dataReferencia = formatDate(new Date(this.consulta.dataReferencia),'yyyyMM', this.locale);
      if(this.consulta.tipoConsulta === 'cpf')
      {
        this.consulta.codigo = `${this.consulta.codigo.substring(0, 3)}${this.consulta.codigo.substring(4, 7)}${this.consulta.codigo.substring(8, 11)}${this.consulta.codigo.substring(12, 14)}`
        this.router.navigate([`consulta/cpf/${this.consulta.codigo}/${this.consulta.dataReferencia}/${this.consulta.intervalo}`]);
      }
      else if(this.consulta.tipoConsulta === 'cnpj')
      {
        this.consulta.codigo = `${this.consulta.codigo.substring(0, 2)}${this.consulta.codigo.substring(3, 6)}${this.consulta.codigo.substring(7, 10)}${this.consulta.codigo.substring(11, 15)}${this.consulta.codigo.substring(16, 18)}`
        this.router.navigate([`consulta/cnpj/${this.consulta.codigo}/${this.consulta.dataReferencia}/${this.consulta.intervalo}`]);
      }
    });
  }
}
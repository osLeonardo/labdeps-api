import { ConsultasService } from './../consultas.service';
import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { Historico } from '../models/historico.Model';

@Component({
  selector: 'app-read-consultas',
  templateUrl: './read-consultas.component.html',
  styleUrls: ['./read-consultas.component.css']
})
export class ReadConsultasComponent implements AfterViewInit, OnInit{

  @ViewChild(MatPaginator) paginator: MatPaginator;

  historico: Historico[] = [];  
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
  dataSource = new MatTableDataSource<Historico>(this.historico);

  

  constructor(private service: ConsultasService){ }

  ngOnInit(): void {
    this.service.GetListHistorico().subscribe(historico => {
      this.historico = historico;
    })
    this.dataSource = this.historico;
  }
  
  ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
  }
  

}
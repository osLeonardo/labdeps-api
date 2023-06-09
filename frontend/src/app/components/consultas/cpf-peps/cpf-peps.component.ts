import { Component, OnInit } from '@angular/core';
import {animate, state, style, transition, trigger} from '@angular/animations';
import { pep } from '../models/pep.Model';
import { ConsultasService } from '../consultas.service';
import { ActivatedRoute, Route } from '@angular/router';

@Component({
  selector: 'app-cpf-peps',
  templateUrl: './cpf-peps.component.html',
  styleUrls: ['./cpf-peps.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class CpfPepsComponent implements OnInit {

  Peps: pep[]

  displayedColumns = ["cpf", "nome", "descricaoFuncao", "nomeOrgao", "dtInicioExercicio", "dtFimExercicio"]

  constructor(private consultaService: ConsultasService, private route: ActivatedRoute) {}

  ngOnInit(): void {
    const codigo: string = `${this.route.snapshot.paramMap.get('codigo')}`
    const codigoFormatado = `${codigo.substring(0,3)}.${codigo.substring(3,6)}.${codigo.substring(6,9)}-${codigo.substring(9)}`
    this.consultaService.GetPepByCpf(codigo).subscribe(Peps => {
      for(let element of Peps){
        element.cpf = codigoFormatado;
      }
      this.Peps = Peps;
    })
  }

  columnsToDisplayWithExpand = [...this.displayedColumns, 'expand'];
  expandedElement:  pep[];
}

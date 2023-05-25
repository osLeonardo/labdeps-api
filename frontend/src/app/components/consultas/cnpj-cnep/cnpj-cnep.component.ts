import { Cnep } from './../models/cnep.model';
import { Component, OnInit } from '@angular/core';
import { ConsultasService } from '../consultas.service';
import { ActivatedRoute, Router } from '@angular/router';
import {animate, state, style, transition, trigger} from '@angular/animations';

@Component({
  selector: 'app-cnpj-cnep',
  templateUrl: './cnpj-cnep.component.html',
  styleUrls: ['./cnpj-cnep.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ]
})

export class CnpjCnepComponent implements OnInit{

  cnep: Cnep[];

  constructor(private consultasService: ConsultasService, private route: ActivatedRoute){ }

  ngOnInit(): void {
    const codigo = `${this.route.snapshot.paramMap.get('codigo')}`;
    this.consultasService.GetCnepByCnpj(codigo).subscribe(cnep => {
      this.cnep = cnep;
    })
  }
  columnsToDisplayWithExpand = [
    'sancionado',
    'tipoSancao',
    'orgaoSancionador.nome',
    'orgaoSancionador.siglaUf',
    'orgaoSancionador.poder',
    'numeroProcesso',
    'valorMulta',
    'expand'
  ];
  expandedElement: Cnep | null;

  displayedColumns = [
    'codigo',
    'descricao'
  ];
}
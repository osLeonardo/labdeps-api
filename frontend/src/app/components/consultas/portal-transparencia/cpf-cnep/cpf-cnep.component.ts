import { Component, OnInit } from '@angular/core';
import { Cnep } from '../models/cnep.Model';
import {animate, state, style, transition, trigger} from '@angular/animations';
import { ActivatedRoute } from '@angular/router';
import { PortalTransparenciaService } from '../portal-transparencia.service';

@Component({
  selector: 'app-cpf-cnep',
  templateUrl: './cpf-cnep.component.html',
  styleUrls: ['./cpf-cnep.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ]
})

export class CpfCnepComponent implements OnInit{
  
  cnep: Cnep[];

  constructor(private portalService: PortalTransparenciaService, private route: ActivatedRoute){}
  
  ngOnInit(): void {
    const codigo = `${this.route.snapshot.paramMap.get('codigo')}`;
    this.portalService.GetCnepByCnpj(codigo).subscribe(cnep => {
      this.cnep = cnep
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
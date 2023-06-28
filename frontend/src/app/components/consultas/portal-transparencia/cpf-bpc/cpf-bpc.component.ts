import { Component, OnInit } from '@angular/core';
import {animate, state, style, transition, trigger} from '@angular/animations';
import { bpc } from '../models/bpc.Model';
import { ActivatedRoute, Route } from '@angular/router';
import { PortalTransparenciaService } from '../portal-transparencia.service';

@Component({
  selector: 'app-cpf-bpc',
  templateUrl: './cpf-bpc.component.html',
  styleUrls: ['./cpf-bpc.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class CpfBpcComponent implements OnInit {

  Bpc: bpc[]

  displayedColumns = ["id", "beneficiario.cpfFormatado", "beneficiario.nome", "beneficiario.nis", "municipio.pais", "municipio.uf.nome"]

  constructor(private portalService: PortalTransparenciaService, private route: ActivatedRoute) {}

  ngOnInit(): void {
    const codigo: string = `${this.route.snapshot.paramMap.get('codigo')}`
    this.portalService.GetBpcByCpf(codigo).subscribe(bpc => {
      this.Bpc = bpc;
    })
  }
	
  columnsToDisplayWithExpand = [...this.displayedColumns, 'expand'];
  expandedElement:  bpc[];

}


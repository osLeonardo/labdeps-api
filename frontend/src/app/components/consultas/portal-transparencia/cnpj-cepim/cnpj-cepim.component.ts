import { CepimByCnpj } from '../models/cepimByCnpj.Model';
import { Component, OnInit } from '@angular/core';
import { animate, state, style, transition, trigger } from '@angular/animations';
import { ConsultasService } from '../../consultas.service';
import { ActivatedRoute} from '@angular/router';
import { PortalTransparenciaService } from '../portal-transparencia.service';

@Component({
  selector: 'app-cnpj-cepim',
  templateUrl: './cnpj-cepim.component.html',
  styleUrls: ['./cnpj-cepim.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({ height: '0px', minHeight: '0' })),
      state('expanded', style({ height: '*' })),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class CnpjCepimComponent implements OnInit {

  cepim: CepimByCnpj[];

  constructor(private portalService: PortalTransparenciaService, private route: ActivatedRoute) { }

  ngOnInit(): void {

    const codigo: string = `${this.route.snapshot.paramMap.get('codigo')}`;
     this.portalService.GetCepimByCnpj(codigo).subscribe((cepim) => {
       this.cepim = cepim;
     });
  }

  columnsToDisplay = [
    "pessoaJuridica.nome", 
    "pessoaJuridica.nomeFantasiaReceita", 
    "pessoaJuridica.numeroInscricaoSocial", 
    "pessoaJuridica.razaoSocialReceita", 
    "pessoaJuridica.tipo", 
    "motivo",
    "pessoaJuridica.cnpjFormatado",
    "dataReferencia"
  ];

  columnsToDisplayWithExpand = [...this.columnsToDisplay, 'expand'];
  expandedElement: null
  dataSource2: CepimByCnpj[]
  columnsDisplay = ["convenio", "orgaoSuperior", "orgaoMaximo", ""]

}


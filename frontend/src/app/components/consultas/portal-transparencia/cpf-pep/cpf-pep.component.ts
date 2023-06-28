import { Component } from '@angular/core';
import { PortalTransparenciaService } from '../portal-transparencia.service';
import { ActivatedRoute } from '@angular/router';
import { pep } from '../models/pep.Model';
import { animate, state, style, transition, trigger } from '@angular/animations';

@Component({
  selector: 'app-cpf-pep',
  templateUrl: './cpf-pep.component.html',
  styleUrls: ['./cpf-pep.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class CpfPepComponent {
  Peps: pep[]

  displayedColumns = ["cpf", "nome", "descricaoFuncao", "nomeOrgao", "dtInicioExercicio", "dtFimExercicio"]

  constructor(private portalService: PortalTransparenciaService, private route: ActivatedRoute) {}

  ngOnInit(): void {
    const codigo: string = `${this.route.snapshot.paramMap.get('codigo')}`
    const codigoFormatado = `${codigo.substring(0,3)}.${codigo.substring(3,6)}.${codigo.substring(6,9)}-${codigo.substring(9)}`
    this.portalService.GetPepByCpf(codigo).subscribe(Peps => {
      for(let element of Peps){
        element.cpf = codigoFormatado;
      }
      this.Peps = Peps;
    })
  }

  columnsToDisplayWithExpand = [...this.displayedColumns, 'expand'];
  expandedElement:  pep[];
}

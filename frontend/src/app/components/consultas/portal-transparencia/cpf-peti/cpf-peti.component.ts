import { Component } from '@angular/core';
import { PortalTransparenciaService } from '../portal-transparencia.service';
import { ActivatedRoute } from '@angular/router';
import { peti } from '../models/peti.Model';

@Component({
  selector: 'app-cpf-peti',
  templateUrl: './cpf-peti.component.html',
  styleUrls: ['./cpf-peti.component.css']
})
export class CpfPetiComponent {
  peti: peti[]

  constructor(
    private portalService: PortalTransparenciaService,
    private route: ActivatedRoute
  ){}
  
  ngOnInit(): void {
    const codigo: string = `${this.route.snapshot.paramMap.get('codigo')}`
    this.portalService.GetPetiByCpf(codigo).subscribe(peti =>{
      this.peti = peti
    });
}

  displayedColumns = ['nome', 'cpfFormatado', 'nis', 'situacao', 'dataDisponibilizacaoRecurso', 'dataMesReferencia', 'nomeIBGE', 'sigla'];
}

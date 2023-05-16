import { Component, OnInit } from '@angular/core';
import { Cnep } from '../models/cnep.model';
import { ConsultasService } from '../consultas.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-cnpj-cnep',
  templateUrl: './cnpj-cnep.component.html',
  styleUrls: ['./cnpj-cnep.component.css']
})
export class CnpjCnepComponent implements OnInit{

  cnep: Cnep[];
  displayedColumns = [
    'sancionado',
    'tipoSancao',
    'orgaoSancionador.nome',
    'orgaoSancionador.siglaUf',
    'orgaoSancionador.poder',
    'numeroProcesso',    
    'valorMulta',
    'dataInicioSancao',
    'dataFimSancao',    
    'dataOrigemInformacao',
    'dataPublicacaoSancao',
    'dataReferencia',
    'dataTransitadoJulgado',
    'textoPublicacao',
    'detalhamentoPublicacao',
    'linkPublicacao'
  ];

  constructor(private consultasService: ConsultasService, private route: ActivatedRoute){ }

  ngOnInit(): void {
    const codigo = "";
    this.consultasService.GetCnepByCnpj(codigo).subscribe(cnep => {
      this.cnep = cnep
    })
  }
}
/*
abrangenciaDefinidaDecisaoJudicial
detalhamentoPublicacao: string
fonteSancao: FonteSancao;
fundamentacao: Fundamentacao[];
informacoesAdicionaisDoOrgaoSancionador: string;
orgaoSancionador: OrgaoSancionador;
textoPublicacao: string;
*/
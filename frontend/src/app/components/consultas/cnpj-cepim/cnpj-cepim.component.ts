import { CepimByCnpj } from './../model/cepimByCnpj.Model';
import { Component, OnInit } from '@angular/core';
import { animate, state, style, transition, trigger } from '@angular/animations';
import { ConsultasService } from '../consultas.service';

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

  dataSource = cepim
  // 'id', 'motivo', 'dataReferencia'
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


  constructor(private ConsultasService: ConsultasService) { }

  ngOnInit(): void {
    const codigo = "06947283000160"; // mudar dps para a rota que vamos fazer
    this.ConsultasService.GetCepimByCnpj(codigo).subscribe((cepim) => {
      this.cepim = cepim;
      console.log(cepim)
    });
  }
}

const cepim: CepimByCnpj[] = [
  {
    convenio: {
      codigo: "01",
      numero: "02",
      objeto: "jhulia",
    },
    dataReferencia: "14/02/2002",
    id: 1,
    motivo: "crime",
    orgaoSuperior: {
      cnpj: "06947283000160",
      codigoSIAFI: "06947283000160",
      descricaoPoder: "forte",
      nome: "bruno",
      orgaoMaximo: {
        codigo: "01",
        nome: "joao",
        sigla: "Jao",
      },
      sigla: "BR",
    },
    pessoaJuridica: {
      cnpjFormatado: "06947283000160",
      cpfFormatado: "06947283000160",
      id: 1,
      nome: "Leonardo",
      nomeFantasiaReceita: "Leo",
      numeroInscricaoSocial: "Leoncio",
      razaoSocialReceita: "bolinha de golfe",
      tipo: "foca",
    }
  }
]

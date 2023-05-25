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

//   var cnep: Cnep[] = [
//   {
//     abrangenciaDefinidaDecisaoJudicial : "Abrangência",
//     dataFimSancao: "DF/MM/AAAA",
//     dataInicioSancao: "DI/MM/AAAA",
//     dataOrigemInformacao: "DO/MM/AAAA",
//     dataPublicacaoSancao: "DP/MM/AAAA",
//     dataReferencia: "DR/MM/AAAA",
//     dataTransitadoJulgado: "DT/MM/AAAA",
//     detalhamentoPublicacao: "Detalhamento da publicação",
//     fonteSancao: 
//     {
//       enderecoContato: "Endereço da fonte",
//       nomeExibicao: "Fonte da sancao",
//       telefoneContato: "(XX) 9 1234-5678",
//     },
//     fundamentacao:
//     [
//       {
//         codigo: "F01",
//         descricao: "Fundamentação 01"
//       },
//       {
//         codigo: "F02",
//         descricao: "Fundamentação 0"
//       },
//     ],
//     id: 0,
//     informacoesAdicionaisDoOrgaoSancionador: "Informações adicionais",
//     linkPublicacao: "http://link.publicacao.com",
//     numeroProcesso: "0011223456/789",
//     orgaoSancionador:
//     {
//       nome: "Nome do Órgão",
//       poder: "Nome poder",
//       siglaUf: "UF"
//     },
//     pessoa: 
//     {
//       cnpjFormatado: "01.234.567/0001-89",
//       cpfFormatado: "123.456.789-00",
//       id: 0,
//       nome: "Nome da pessoa",
//       nomeFantasiaReceita: "Nome fantasia",
//       numeroInscricaoSocial: "123456789",
//       razaoSocialReceita: "Razão social",
//       tipo: "Tipo Pessoa"
//     },
//     sancionado: 
//     {
//       codigoFormatado: "123",
//       nome: "Nome do Sancionado"
//     },
//     textoPublicacao: "Texto de publicação",
//     tipoSancao: 
//     {
//       descricaoPortal: "Decrição completa do tipo da sanção",
//       descricaoResumida: "Descrição resumida"
//     },
//     valorMulta: "R$ 1.000,00",
//   }
// ];
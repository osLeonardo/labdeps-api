import { Component, Inject, OnInit } from '@angular/core';
import { animate, state, style, transition, trigger } from '@angular/animations';
import { DOCUMENT } from '@angular/common';
import { AuthService } from 'src/app/views/login/login.service';
import { UsuarioCreateComponent } from '../../administracao/usuario-create/usuario-create.component';
import { UsuarioReadComponent } from '../../administracao/usuario-read/usuario-read.component';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class NavComponent implements OnInit{

  id: number;
  nome: string;

  constructor(
    @Inject(DOCUMENT)
    public document: Document,
    public loginService: AuthService,
    ) {}

  sair(){
    this.loginService.logout();
  }

  async ngOnInit(): Promise<void> {
    this.nome = await this.loginService.getNomePerfil();
    this.id = this.loginService.getUserId();
  }
}
import { Component, Inject } from '@angular/core';
import { animate, state, style, transition, trigger } from '@angular/animations';
import { DOCUMENT } from '@angular/common';
import { AuthService } from 'src/app/views/login/login.service';

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
export class NavComponent {
  expandir = false;
  constructor(@Inject(DOCUMENT) public document: Document, public auth: AuthService) {}

  sair(){
    this.auth.logout();
  }
}


function rodaBotao() {
  const button = document.getElementById("rotate-button") as HTMLButtonElement;
  button.classList.toggle("rotated");
}

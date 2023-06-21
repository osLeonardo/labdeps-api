
import { Component, OnInit } from '@angular/core';
import { Usuarios } from '../models/usuarios.Model';
import { AdministracaoService } from '../administracao.service';
import { ActivatedRoute, Router } from '@angular/router';



@Component({
  selector: 'app-usuario-update',
  templateUrl: './usuario-update.component.html',
  styleUrls: ['./usuario-update.component.css']
})
export class UsuarioUpdateComponent implements OnInit {

  // o erro é que para fazer o update, é preciso ter um userName, n um login, tem q ser arrumado no backend para funcionar
  usuario: Usuarios = {
    id: 0,
    nome: '',
    sobrenome: '',
    login: '',
    password: '',
    perfilUsuario: 0,
    ativo: false
  }
  
  constructor(private AdministracaoService: AdministracaoService, private router: Router, private route: ActivatedRoute) {}
  
  ngOnInit(): void {
    const id = parseInt(`${this.route.snapshot.paramMap.get('id')}`);

    this.AdministracaoService.readById(id).subscribe((usuario) => {    
      this.usuario = usuario
    })
  }

  AtualizarUsuario(): void {
    this.AdministracaoService.atualizar(this.usuario).subscribe(usuario => {
      this.usuario = usuario
      console.log(this.usuario);
      this.router.navigate(['/administracao'])
     })
  }
  cancelar(): void {
    this.router.navigate(['/administracao'])
  }
}






import { Component, OnInit } from '@angular/core';
import { CreateUsuarios, Perfil } from '../models/create-usuarios.Model';
import { AdministracaoService } from '../administracao.service';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-usuario-update',
  templateUrl: './usuario-update.component.html',
  styleUrls: ['./usuario-update.component.css']
})
export class UsuarioUpdateComponent implements OnInit {

  // o erro é que para fazer o update, é preciso ter um userName, n um login, tem q ser arrumado no backend para funcionar
  usuario: CreateUsuarios = {
    id: 0,
    login: '',
    password: '',
    perfilUsuario: 0,
    perfil: {
      id: 0
    }
  }
  


  constructor(private AdministracaoService: AdministracaoService, private router: Router, private route: ActivatedRoute) {}
  
  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id')
    const ide = `${id}`
    const idNumber = parseInt(ide, 10);
    this.AdministracaoService.readById(idNumber).subscribe(usuario =>{
      this.usuario = usuario
    })
  }

  AtualizarUsuario(): void {
    this.AdministracaoService.atualizar(this.usuario).subscribe(() => {
      console.log(this.usuario);
      this.router.navigate(['/administracao'])
      
     }) 
  }
  cancelar(): void {
    this.router.navigate(['/administracao'])
  }
}





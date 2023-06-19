
import { Component, OnInit } from '@angular/core';
import { CreateUsuarios } from '../models/usuarios.Model';
import { AdministracaoService } from '../administracao.service';
import { ActivatedRoute, Router } from '@angular/router';
import { CreatePerfil } from '../models/perfil.Model'



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
      id: 0,
    }
  }
  perfil: CreatePerfil = {
    id: 0,
    nome: '',
    ativo: true,
    ordem: 0
  }
  
  constructor(private AdministracaoService: AdministracaoService, private router: Router, private route: ActivatedRoute) {}
  
  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id')
    const idPerfil = this.route.snapshot.paramMap.get('idPerfil')

    const ide = `${id}`
    const idePerfil = `${idPerfil}`

    const idNumber = parseInt(ide, 10);
    const idPerfilNumber = parseInt(idePerfil, 10)

    this.AdministracaoService.getByIdPerfil(idPerfilNumber).subscribe((perfil) => {
    
    this.perfil = perfil
    this.AdministracaoService.readById(idNumber).subscribe((usuario) => {
      this.usuario = usuario
    })
    })
  }
  AtualizarUsuario(): void {
    this.AdministracaoService.atualizarPerfil(this.perfil).subscribe(() => {
      this.AdministracaoService.atualizar(this.usuario).subscribe(() => {
        console.log(this.usuario);
        this.router.navigate(['/administracao'])
       }) 
    })

  }
  cancelar(): void {
    this.router.navigate(['/administracao'])
  }
}





import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CpfConsultaComponent } from './views/cpf-consulta/cpf-consulta.component';
import { CnpjConsultaComponent } from './views/cnpj-consulta/cnpj-consulta.component';
import { HomeComponent } from './views/home/home.component';
import { ConsultasComponent } from './views/consultas/consultas.component';
import { CrudAdministracaoComponent } from './views/crud-administracao/crud-administracao.component';
import { UsuarioCreateComponent } from './components/administracao/usuario-create/usuario-create.component';
import { LoginComponent } from './views/login/login.component';
import { UsuarioUpdateComponent } from './components/administracao/usuario-update/usuario-update.component';
import { UsuariosComponent } from './views/usuarios/usuarios.component';
import { UsuariosAlteracaoComponent } from './components/usuarios/usuarios-alteracao/usuarios-alteracao.component';
import { UsuariosAlterarComponent } from './views/usuarios/usuarios-alterar/usuarios-alterar.component';

const routes: Routes = [ 
  {
    path: "",
    component: HomeComponent
  },
  {
    path: "consulta",
    component: ConsultasComponent
  },
  {
    path: "consulta/cpf/:codigo/:dataRef/:intervalo",
    component: CpfConsultaComponent
  },
  {
    path: "consulta/cnpj/:codigo/:dataRef/:intervalo",
    component: CnpjConsultaComponent
  },
  {
    path: "administracao",
    component: CrudAdministracaoComponent
  },
  {
    path: "administracao/cadastrar",
    component: UsuarioCreateComponent
  },
  {
    path: "administracao/atualizarUsuario/:id",
    component: UsuarioUpdateComponent
  },
  {
    path: "login",
    component: LoginComponent
  },
  {
    path: "usuarios/:id",
    component: UsuariosComponent
  },
  {
    path: "usuarios/:id/usuariosAlterar",
    component: UsuariosAlterarComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
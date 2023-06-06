import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CpfConsultaComponent } from './views/cpf-consulta/cpf-consulta.component';
import { CnpjConsultaComponent } from './views/cnpj-consulta/cnpj-consulta.component';
import { HomeComponent } from './views/home/home.component';
import { ConsultasComponent } from './views/consultas/consultas.component';
import { LoginComponent } from './views/login/login.component';
import { RegistroComponent } from './views/registro/registro.component';
import { CrudAdministracaoComponent } from './views/crud-administracao/crud-administracao.component';
import { UsuarioCreateComponent } from './components/administracao/usuario-create/usuario-create.component';

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
    path: "login",
    component: LoginComponent
  },
  {
    path: "registro",
    component: RegistroComponent
  },
  {
    path: "administracao",
    component: CrudAdministracaoComponent
  },
  {
    path: "administracao/cadastrar",
    component: UsuarioCreateComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CpfConsultaComponent } from './views/cpf-consulta/cpf-consulta.component';
import { CnpjConsultaComponent } from './views/cnpj-consulta/cnpj-consulta.component';
import { ConsultasComponent } from './views/consultas/consultas.component';
import HomeComponent from './views/home/home.component';

export const routes: Routes = [ 
  {
    path: "", 
    //loadComponent: () => import('./views/home/home.component'),
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
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {
    initialNavigation: 'enabledBlocking'
})],
  exports: [RouterModule]
})
export class AppRoutingModule { }
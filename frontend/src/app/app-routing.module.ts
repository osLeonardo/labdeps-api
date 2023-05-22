import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CpfConsultaComponent } from './views/cpf-consulta/cpf-consulta.component';
import { CnpjConsultaComponent } from './views/cnpj-consulta/cnpj-consulta.component';

const routes: Routes = [ 
  {
    path: "consulta/cpf/:codigo",
    component: CpfConsultaComponent
  },
  {
    path: "consulta/cnpj/:codigo",
    component: CnpjConsultaComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
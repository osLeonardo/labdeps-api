import { ReadConsultasComponent } from './components/consultas/read-consultas/read-consultas.component';
import { NgModule, LOCALE_ID } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HeaderComponent } from './components/template/header/header.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { NavComponent } from './components/template/nav/nav.component';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import { HomeComponent } from './views/home/home.component';
import { ConsultasComponent } from './views/consultas/consultas.component';
import { MatDialogModule } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { DialogConsultasComponent } from './views/consultas/dialog-consultas/dialog-consultas.component';
import { MatSelectModule } from '@angular/material/select';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { FormsModule } from '@angular/forms';
import { CnpjConsultaComponent } from './views/cnpj-consulta/cnpj-consulta.component';
import { CpfConsultaComponent } from './views/cpf-consulta/cpf-consulta.component';
import { CnpjCepimComponent } from './components/consultas/portal-transparencia/cnpj-cepim/cnpj-cepim.component';
import { AppRoutingModule } from './app-routing.module';
import { MatIconModule } from '@angular/material/icon';
import { HttpClientModule } from '@angular/common/http';
import { MatCardModule } from '@angular/material/card';
import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';
import { NgIf } from '@angular/common';
import { MatExpansionModule } from '@angular/material/expansion';
import { NgxMaskModule } from 'ngx-mask';
import localePt from '@angular/common/locales/pt';
import { registerLocaleData } from '@angular/common';
import { UsuarioCreateComponent } from './components/administracao/usuario-create/usuario-create.component'
import { UsuarioReadComponent } from './components/administracao/usuario-read/usuario-read.component'
import { UsuarioUpdateComponent } from './components/administracao/usuario-update/usuario-update.component'
import { CrudAdministracaoComponent } from './views/crud-administracao/crud-administracao.component';
import { LoginComponent } from './views/login/login.component';
import { MatPaginatorModule } from '@angular/material/paginator';
import { LoginDialogComponent } from './views/login/dialog-login.component';
import { UsuariosComponent } from './views/usuarios/usuarios.component';
import { UsuariosAlteracaoComponent } from './components/usuarios/usuarios-alteracao/usuarios-alteracao.component';
import { UsuariosAlterarComponent } from './views/usuarios/usuarios-alterar/usuarios-alterar.component';
import { UsuariosDadosComponent } from './components/usuarios/usuarios-dados/usuarios-dados.component';
import { MatSortModule } from '@angular/material/sort';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { CpfBolsaFamiliaComponent } from './components/consultas/portal-transparencia/cpf-bolsa-familia/cpf-bolsa-familia.component';
import { CpfPepComponent } from './components/consultas/portal-transparencia/cpf-pep/cpf-pep.component';
import { CpfPetiComponent } from './components/consultas/portal-transparencia/cpf-peti/cpf-peti.component';
import { CnpjCnepComponent } from './components/consultas/portal-transparencia/cnpj-cnep/cnpj-cnep.component';
import { CpfCnepComponent } from './components/consultas/portal-transparencia/cpf-cnep/cpf-cnep.component';
import { CnpjLenienciaComponent } from './components/consultas/portal-transparencia/cnpj-leniencia/cnpj-leniencia.component';
import { CpfBpcComponent } from './components/consultas/portal-transparencia/cpf-bpc/cpf-bpc.component';
import { CpfRemuneracaoComponent } from './components/consultas/portal-transparencia/cpf-remuneracao/cpf-remuneracao.component';
import { CpfCepimComponent } from './components/consultas/portal-transparencia/cpf-cepim/cpf-cepim.component';
import { CnpjDadosPublicosComponent } from './components/consultas/dados-publicos/cnpj-dados-publicos/cnpj-dados-publicos.component';
import { MatTooltipModule } from '@angular/material/tooltip';

registerLocaleData(localePt)

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    NavComponent,
    CnpjCnepComponent,
    CpfCnepComponent,
    HomeComponent,
    ConsultasComponent,
    DialogConsultasComponent,
    CnpjConsultaComponent,
    CpfConsultaComponent,
    CnpjCepimComponent,
    CnpjLenienciaComponent,
    CpfBpcComponent,
    CpfPepComponent,
    CpfRemuneracaoComponent,
    CpfPetiComponent,
    CpfBolsaFamiliaComponent,
    CpfCepimComponent,
    UsuarioCreateComponent,
    UsuarioReadComponent,
    UsuarioUpdateComponent,
    CrudAdministracaoComponent,
    LoginComponent,
    ReadConsultasComponent,
    LoginDialogComponent,
    UsuariosComponent,
    UsuariosAlteracaoComponent,
    UsuariosAlterarComponent,
    UsuariosDadosComponent,
    CpfBolsaFamiliaComponent,
    CpfPepComponent,
    CpfPetiComponent,
    CnpjDadosPublicosComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatListModule,
    MatSidenavModule,
    HttpClientModule,
    MatDialogModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatDatepickerModule,
    MatNativeDateModule,
    FormsModule,
    AppRoutingModule,
    MatTableModule,
    MatIconModule,
    MatCardModule,
    MatButtonModule,
    MatTooltipModule,
    MatSnackBarModule,
    MatExpansionModule,
    MatPaginatorModule,
    MatSortModule,
    NgIf,
    NgxMaskModule.forRoot({
      dropSpecialCharacters: false
    }),
  ],
  providers: [{
    provide: LOCALE_ID,
    useValue: 'pt-BR',
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }

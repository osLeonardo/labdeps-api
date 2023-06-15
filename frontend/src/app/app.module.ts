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
import { CnpjCnepComponent } from './components/consultas/cnpj-cnep/cnpj-cnep.component';
import { CpfCnepComponent } from './components/consultas/cpf-cnep/cpf-cnep.component';
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
import { CnpjCepimComponent } from './components/consultas/cnpj-cepim/cnpj-cepim.component';
import { CnpjLenienciaComponent } from './components/consultas/cnpj-leniencia/cnpj-leniencia.component';
import { CpfBpcComponent } from './components/consultas/cpf-bpc/cpf-bpc.component';
import { CpfPepsComponent } from './components/consultas/cpf-peps/cpf-peps.component';
import { CpfRemuneracaoComponent } from './components/consultas/cpf-remuneracao/cpf-remuneracao.component';
import { AppRoutingModule } from './app-routing.module';
import { MatIconModule } from '@angular/material/icon';
import { HttpClientModule } from '@angular/common/http';
import { BolsaFamiliaComponent } from './components/consultas/cpf-bolsa-familia/bolsa-familia.component';
import { PetiComponent } from './components/consultas/cpf-peti/peti.component';
import { MatCardModule } from '@angular/material/card';
import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';
import { NgIf } from '@angular/common';
import { MatExpansionModule } from '@angular/material/expansion';
import { CpfCepimComponent} from './components/consultas/cpf-cepim/cpf-cepim.component';
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
    CpfPepsComponent,
    CpfRemuneracaoComponent,
    PetiComponent,
    BolsaFamiliaComponent,
    CpfCepimComponent,
    UsuarioCreateComponent,
    UsuarioReadComponent,
    UsuarioUpdateComponent,
    CrudAdministracaoComponent,
    LoginComponent,
    ReadConsultasComponent,
    LoginDialogComponent,
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
    NgIf,
    MatExpansionModule,
    MatPaginatorModule,
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

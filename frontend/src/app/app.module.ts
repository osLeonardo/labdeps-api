import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HeaderComponent } from './components/template/header/header.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { NavComponent } from './components/template/nav/nav.component';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import { CnpjCepimComponent } from './components/consultas/cnpj-cepim/cnpj-cepim.component';
import { CnpjLenenciaComponent } from './components/consultas/cnpj-lenencia/cnpj-lenencia.component';
import { CpfBpcComponent } from './components/consultas/cpf-bpc/cpf-bpc.component';
import { CpfPepsComponent } from './components/consultas/cpf-peps/cpf-peps.component';
import { CpfRemuneracaoComponent } from './components/consultas/cpf-remuneracao/cpf-remuneracao.component';
import { AppRoutingModule } from './app-routing.module';
import { MatIconModule } from '@angular/material/icon';
import { HttpClientModule } from '@angular/common/http';
import { BolsaFamiliaComponent } from './components/consultas/bolsa-familia/bolsa-familia.component';
import { PetiComponent } from './components/consultas/peti/peti.component';
import { MatCardModule } from '@angular/material/card';
import { MatTableModule } from '@angular/material/table';
import { CPFNISComponent } from './components/consultas/cpfnis/cpfnis.component';
import { MatButtonModule } from '@angular/material/button';
import { NgIf } from '@angular/common';
import { CnpjnisComponent } from './components/consultas/cnpjnis/cnpjnis.component';
import { MatExpansionModule } from '@angular/material/expansion';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    NavComponent,
    CnpjCepimComponent,
    CnpjLenenciaComponent,
    CpfBpcComponent,
    CpfPepsComponent,
    CpfRemuneracaoComponent,
    PetiComponent,
    BolsaFamiliaComponent,
    CPFNISComponent,
    CnpjnisComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatListModule,
    MatSidenavModule,
    HttpClientModule,
    AppRoutingModule,
    MatTableModule,
    MatIconModule,
    MatCardModule,
    MatButtonModule,
    NgIf,
    MatExpansionModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

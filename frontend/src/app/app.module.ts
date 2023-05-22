import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HeaderComponent } from './components/template/header/header.component';

import { MatToolbarModule } from '@angular/material/toolbar';
import { NavComponent } from './components/template/nav/nav.component'

import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import { HttpClientModule } from '@angular/common/http';
import { CnpjCnepComponent } from './components/consultas/cnpj-cnep/cnpj-cnep.component';
import { MatTableModule } from '@angular/material/table';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
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
import { CpfConsultaComponent } from './views/cpf-consulta/cpf-consulta.component'



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
    CpfConsultaComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatListModule,
    MatSidenavModule,
    HttpClientModule,
    MatTableModule,
    MatIconModule,
    MatButtonModule,
    MatCardModule,
    MatDialogModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatDatepickerModule,
    MatNativeDateModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

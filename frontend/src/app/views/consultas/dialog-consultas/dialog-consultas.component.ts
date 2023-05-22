import { Component } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';
import { Router } from '@angular/router';

@Component({
  selector: 'app-dialog-consultas',
  templateUrl: './dialog-consultas.component.html',
  styleUrls: ['./dialog-consultas.component.css']
})
export class DialogConsultasComponent {

  consulta = 'cpf';
  intervalo = '3';
  dataReferencia = new Date();
  codigo: string;


  constructor(public dialogRef: MatDialogRef<DialogConsultasComponent>, private router: Router) {}

    Buscar(): void{
      if(this.consulta === 'cpf')
      {
        this.router.navigate([`consulta/cpf/${this.codigo}`]);
      }
      else if(this.consulta === 'cnpj')
      {
        this.router.navigate([`consulta/cnpj/${this.codigo}`]);
      }
      
    }
}

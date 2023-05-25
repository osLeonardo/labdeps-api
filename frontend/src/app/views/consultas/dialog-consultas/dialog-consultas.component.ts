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
  button = true;

  constructor(public dialogRef: MatDialogRef<DialogConsultasComponent>, private router: Router) {}

  EnableButton(): void{
    this.button = this.codigo ? false : true;
  }

    Buscar(): void{
      const dataRef = `${this.dataReferencia.getFullYear().toString()}${(this.dataReferencia.getMonth() + 1).toString().padStart(2, '0')}`;
      this.dialogRef.close(); 
      
      if(this.consulta === 'cpf')
      {
        this.router.navigate([`consulta/cpf/${this.codigo}/${dataRef}/${this.intervalo}`]);
      }
      else if(this.consulta === 'cnpj')
      {
        this.router.navigate([`consulta/cnpj/${this.codigo}/${dataRef}/${this.intervalo}`]);
      }
           
    }
}

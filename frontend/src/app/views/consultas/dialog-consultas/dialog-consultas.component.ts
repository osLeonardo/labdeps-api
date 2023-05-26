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
        this.codigo = `${this.codigo.substring(0, 3)}${this.codigo.substring(4, 7)}${this.codigo.substring(8, 11)}${this.codigo.substring(12, 14)}`
        this.router.navigate([`consulta/cpf/${this.codigo}/${dataRef}/${this.intervalo}`]);
      }
      else if(this.consulta === 'cnpj')
      {
        this.codigo = `${this.codigo.substring(0, 2)}${this.codigo.substring(3, 6)}${this.codigo.substring(7, 10)}${this.codigo.substring(11, 15)}${this.codigo.substring(16, 18)}`
        this.router.navigate([`consulta/cnpj/${this.codigo}/${dataRef}/${this.intervalo}`]);
      }
           console.log(this.codigo)
    }
}

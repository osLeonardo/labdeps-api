import { ConsultasService } from './../../../components/consultas/consultas.service';
import { Component, HostListener } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { MatButtonModule } from '@angular/material/button';

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

  constructor(public dialogRef: MatDialogRef<DialogConsultasComponent>, private router: Router, private consultasService: ConsultasService) {}  

  CpfValidar(): boolean {
    let cpfNum10:string = `${this.codigo.substring(0, 3)}${this.codigo.substring(4, 7)}${this.codigo.substring(8, 11)}`;
    let somaNum10:number = 0;
    for(let i = 0; i<9; i++){
      somaNum10 += (parseInt(cpfNum10[i]) * (10-i));
    }
    let restoNum10:number = (somaNum10 * 10) % 11;
    if(restoNum10 === 10){
      restoNum10 = 0;
    }
    let character12:number = restoNum10;
    let cpfNum11:string = `${this.codigo.substring(0, 3)}${this.codigo.substring(4, 7)}${this.codigo.substring(8, 11)}${this.codigo.substring(12, 13)}`;
    let somaNum11:number = 0;
    for(let i = 0; i<10; i++){
      somaNum11 += (parseInt(cpfNum11[i]) * (11-i));
    }
    let restoNum11:number = (somaNum11 * 10) % 11
    if(restoNum11 === 10){
      restoNum11 = 0;
    }
    let character13 = restoNum11
    if(character12 === parseInt(this.codigo[12]) && character13 === parseInt(this.codigo[13])){
      return true;
    }
    else{
      return false;
    }
}

  CnpjValidar(): boolean {
    let cnpjNum13_1:string = `${this.codigo.substring(0, 2)}${this.codigo.substring(3, 5)}`;
    let cnpjNum13_2:string = `${this.codigo[5]}${this.codigo.substring(7, 10)}${this.codigo.substring(11, 15)}`;
    let somaNum13_1:number = 0;
    let somaNum13_2:number = 0;
    for(let i = 0; i<4; i++){
      somaNum13_1 += (parseInt(cnpjNum13_1[i]) * (5-i));
    }
    for(let i = 0; i<8; i++){
      somaNum13_2 += (parseInt(cnpjNum13_2[i]) * (9-i));
    }
    let somaNum13:number = somaNum13_1+somaNum13_2;
    let restoNum13:number = somaNum13 % 11;
    if(restoNum13<2){
      restoNum13 = 0;
    }
    else{
      restoNum13 = 11-restoNum13;
    }
    let character16 = restoNum13;
    let cnpjNum14_1:string = `${this.codigo.substring(0, 2)}${this.codigo.substring(3, 6)}`;
    let cnpjNum14_2:string = `${this.codigo[7]}${this.codigo.substring(8, 10)}${this.codigo.substring(11, 15)}${this.codigo.substring(16, 18)}`;
    let somaNum14_1:number = 0;
    let somaNum14_2:number = 0;
    for(let i = 0; i<5; i++){
      somaNum14_1 += (parseInt(cnpjNum14_1[i]) * (6-i));
    }
    for(let i =0; i<8; i++){
      somaNum14_2 += (parseInt(cnpjNum14_2[i]) * (9-i));
    }
    let somaNum14:number = somaNum14_1+somaNum14_2;
    let restoNum14:number = somaNum14 % 11;
    if(restoNum14<2){
      restoNum14 = 0;
    }
    else{
      restoNum14 = 11-restoNum14;
    }
    let character17 = restoNum14;
    if(character16 === parseInt(this.codigo[16]) && character17 === parseInt(this.codigo[17])){
      return true;
    }
    else{
      return false;
    }
  }

  EnableButton(): void{
    if(this.consulta === 'cpf'){
      this.button = this.CpfValidar() ? false : true;
    }
    else{
      this.button = this.CnpjValidar() ? false : true;
    }
  }

  @HostListener('document:keydown.enter',['$event'])
  handleKeyPress(event: KeyboardEvent){
    this.performSearch();
  }

  performSearch(){
    const searchTerm = this.codigo;

    if(!this.button){
      this.Buscar();
    }

    console.log("Realizando a pesquisa: ", searchTerm);
  }

    Buscar(): void{
      this.consultasService.CreateHistorico(this.consulta, this.codigo, this.dataReferencia, this.intervalo).subscribe(historico =>{
        console.log(historico);
      });
      
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
    Cancelar(): void{
      this.dialogRef.close();
    }
}

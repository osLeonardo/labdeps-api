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

  //cpf
  CPFNum10(): boolean {
    let cpf:string = `${this.codigo.substring(0, 3)}${this.codigo.substring(4, 7)}${this.codigo.substring(8, 11)}`;
    let sum:number = 0;
    for(let i = 0; i<9; i++){
        sum += (parseInt(cpf[i]) * (10-i));
    }
    let resto:number = (sum * 10) % 11;
    if(resto === 10){
      resto = 0;
    }
    let Num12:number = resto;
    if(Num12 === parseInt(this.codigo[12])){
      return true;
    }
    else{
      return false;
    }
  }
  CPFNum11(): boolean{
  let cpf:string = `${this.codigo.substring(0, 3)}${this.codigo.substring(4, 7)}${this.codigo.substring(8, 11)}${this.codigo.substring(12, 13)}`;
    let sum:number = 0;
    for(let i = 0; i<10; i++){
        sum += (parseInt(cpf[i]) * (11-i));
    }
    let resto:number = (sum * 10) % 11
    if(resto === 10){
      resto = 0;
    }
    let Num13 = resto
    if(Num13 === parseInt(this.codigo[13])){
      return true;
    }
    else{
      return false;
    }
}
  ValidarCPF(): boolean {
    if(this.CPFNum10() && this.CPFNum11()){
      return true;
    }
    return false;
}
//cnpj
CNPJNum13(): boolean {
  let cnpjParte1:string = `${this.codigo.substring(0, 2)}${this.codigo.substring(3, 5)}`;
  let cnpjParte2:string = `${this.codigo[5]}${this.codigo.substring(7, 10)}${this.codigo.substring(11, 15)}`;
  let sum1:number = 0;
  let sum2:number = 0;
  for(let i = 0; i<4; i++){
    sum1 += (parseInt(cnpjParte1[i]) * (5-i));
  }
  for(let i = 0; i<8; i++){
    sum2 += (parseInt(cnpjParte2[i]) * (9-i));
  }
  let sum:number = sum1+sum2;
  let resto:number = sum % 11;
  if(resto<2){
    resto = 0;
  }
  else{
    resto = 11-resto;
  }
  let Num16 = resto;
  if(Num16 === parseInt(this.codigo[16])){
    return true;
  }
  else{
    return false;
  }
}
CNPJNum14(): boolean {
  let cnpjParte1:string = `${this.codigo.substring(0, 2)}${this.codigo.substring(3, 6)}`;
  let cnpjParte2:string = `${this.codigo[5]}${this.codigo.substring(7, 10)}${this.codigo.substring(11, 18)}`;
  let sum1:number = 0;
  let sum2:number = 0;
  for(let i = 0; i<5; i++){
    sum1 += (parseInt(cnpjParte1[i]) * (6-i));
  }
  for(let i =0; i<8; i++){
    sum2 += (parseInt(cnpjParte2[i]) * (9-i));
  }
  let sum:number = sum1+sum2;
  console.log(sum);
  let resto:number = sum % 11;
  console.log(resto);
  console.log("a");
  if(resto<2){
    resto = 0;
    console.log(resto);
  }
  else{
    resto = 11-resto;
    console.log(resto);
  }
  let Num16 = resto;
  if(Num16 === parseInt(this.codigo[17])){
    console.log("a");
    return true;
  }
  else{
    console.log("b");
    return false;
  }
}
ValidarCNPJ(): boolean {
  if(this.CNPJNum13() && this.CNPJNum14()){
    console.log("a");
    return true;
  }
  console.log("b");
  return false;
}
  EnableButton(): void{
    //this.button = this.codigo ? false : true;
    if(this.consulta === 'cpf'){
      this.button = this.ValidarCPF() ? false : true;
    }
    else{
      this.button = this.ValidarCNPJ() ? false : true;
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

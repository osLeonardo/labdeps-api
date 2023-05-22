import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { DialogConsultasComponent } from './dialog-consultas/dialog-consultas.component';

@Component({
  selector: 'app-consultas',
  templateUrl: './consultas.component.html',
  styleUrls: ['./consultas.component.css']
})
export class ConsultasComponent {

  name: string;

  constructor(public dialog: MatDialog) {}

  openDialog(): void {
    const dialogRef = this.dialog.open(DialogConsultasComponent, {
      data: {name: this.name},
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
      this.name = result;
    });
  }
}


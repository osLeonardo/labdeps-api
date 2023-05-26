import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { DialogConsultasComponent } from './dialog-consultas/dialog-consultas.component';
import { HeaderService } from 'src/app/components/template/header/header.service';

@Component({
  selector: 'app-consultas',
  templateUrl: './consultas.component.html',
  styleUrls: ['./consultas.component.css']
})
export class ConsultasComponent {

  constructor(public dialog: MatDialog, private headerService: HeaderService) {
    headerService.headerData = {
      title: 'Consultas',
      icon: ' search ',
      routeUrl: '/consulta',
    }
  }

  openDialog(): void {
    const dialogRef = this.dialog.open(DialogConsultasComponent);

    dialogRef.afterClosed().subscribe(() => {
      console.log('The dialog was closed');
    });
  }
}


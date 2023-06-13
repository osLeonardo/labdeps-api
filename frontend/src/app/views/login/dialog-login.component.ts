import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-login-dialog',
  template: `
    <h2 mat-dialog-title>Erro</h2>
    <mat-dialog-content>
      <p>{{ errorMessage }}</p>
    </mat-dialog-content>
    <mat-dialog-actions>
      <button mat-button [mat-dialog-close]="'close'">FECHAR</button>
    </mat-dialog-actions>
  `,
})
export class LoginDialogComponent {
  errorMessage: string;

  constructor(@Inject(MAT_DIALOG_DATA) public data: { errorMessage: string }) {
    this.errorMessage = data.errorMessage;
  }
}

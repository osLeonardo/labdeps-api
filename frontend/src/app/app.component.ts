import { Component } from '@angular/core';
import { environment } from 'src/environments/environment.development';

@Component({
  selector: 'app-root',
  templateUrl : 'app.component.html'
})
export class AppComponent {
  title = environment.prjectName;
}

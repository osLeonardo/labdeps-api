import { HeaderService } from './header.service';
import { Component } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {

  constructor(private HeaderService: HeaderService) { }

  get title(): string {
    return this.HeaderService.headerData.title;
  }

  get icon(): string {
    return this.HeaderService.headerData.icon;
  }

  get routeUrl(): string {
    return this.HeaderService.headerData.routeUrl;
  }
}

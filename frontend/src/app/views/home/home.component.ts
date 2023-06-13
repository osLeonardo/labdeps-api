import { HeaderService } from './../../components/template/header/header.service';
import { Component } from '@angular/core';
import {RouterModule} from '@angular/router'

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export default class HomeComponent {

  constructor(private headerService: HeaderService) {
    headerService.headerData = {
      title: 'Início',
      icon: 'home',
      routeUrl: '',
    }
  }

}

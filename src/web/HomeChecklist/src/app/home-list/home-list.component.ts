import { Component, OnInit } from '@angular/core';
import { HomeService } from '../services/home.service';
import { Observable } from 'rxjs';
import { Home } from '../interfaces/home';

@Component({
  selector: 'app-home-list',
  templateUrl: './home-list.component.html',
  styleUrls: ['./home-list.component.css']
})
export class HomeListComponent implements OnInit {

  private homes: Observable<Home[]>;
  private selectedHome: Home;

  constructor(private homeService: HomeService) {
    this.homes = homeService.getHomes();
  }

  ngOnInit() {
  }

  newHome(): void {
    this.selectedHome = { id: null, name: null }
  }

  updateHomes(home: Home) {
    this.homes = this.homeService.getHomes();
    this.selectedHome = null;
  }
}

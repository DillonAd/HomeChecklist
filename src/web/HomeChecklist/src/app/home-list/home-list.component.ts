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

  homes: Observable<Home[]>;
  selectedHome: Home;

  constructor(private homeService: HomeService) {
    this.refreshHomes();
  }

  ngOnInit() {
  }

  createHome(home: Home) {
    this.homeService.createHome(home).subscribe();
    this.refreshHomes();
  }

  updateHome(home: Home) {
    this.homeService.updateHome(home).subscribe();
    this.refreshHomes();
  }

  newHome() {
    this.selectedHome = { id: null, name: null };
  }

  editHome(home: Home) {
      this.selectedHome = { id: home.id, name: home.name };
  }

  deleteHome(home: Home) {
    this.homeService.deleteHome(home.id).subscribe();
    this.refreshHomes();
  }

  refreshHomes() {
    this.homes = this.homeService.getHomes();
    this.selectedHome = null;
  }
}

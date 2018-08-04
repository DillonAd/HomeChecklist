import { Component, OnInit, Input } from '@angular/core';
import { Home } from '../interfaces/home';
import { HomeService } from '../services/home.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  @Input() show: boolean;
  @Input() home: Home;

  constructor(private homeService: HomeService) { }

  ngOnInit() {
  }

  addHome() {
    this.home.Id = 1;
    console.log(this.home);
    this.homeService.createHome(this.home)
      .subscribe();
  }

  editHome() {
    this.homeService.updateHome(this.home);
  }

  deleteHome() {
    this.homeService.deleteHome(this.home.Id);
  }
}

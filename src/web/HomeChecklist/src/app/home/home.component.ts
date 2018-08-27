import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Home } from '../interfaces/home';
import { HomeService } from '../services/home.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  @Input() home: Home;
  @Output() homeChanged = new EventEmitter();

  constructor(private homeService: HomeService) { }

  ngOnInit() {
  }

  addHome() {
    console.log(this.home);
    this.homeService.createHome(this.home)
      .subscribe(
        complete => this.homeChanged.emit(this.home)
      );
  }

  updateHome() {
    this.homeService.updateHome(this.home)
      .subscribe(
        complete => this.homeChanged.emit(this.home)
      );
  }

  deleteHome() {
    this.homeService.deleteHome(this.home.id)
      .subscribe(
        complete => this.homeChanged.emit(this.home)
      );
  }

  cancel() {
    this.home = null;
  }
}

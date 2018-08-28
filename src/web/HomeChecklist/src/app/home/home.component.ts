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
  @Output() homeCreated: EventEmitter<Home> = new EventEmitter();
  @Output() homeChanged: EventEmitter<Home> = new EventEmitter();

  constructor() { }

  ngOnInit() {
  }

  createHome() {
    this.homeCreated.emit(this.home);
  }

  updateHome() {
    this.homeChanged.emit(this.home);
  }

  cancel() {
    this.home = null;
  }
}

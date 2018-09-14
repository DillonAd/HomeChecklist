import { Room } from './../interfaces/room';
import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-room',
  templateUrl: './room.component.html',
  styleUrls: ['./room.component.css']
})
export class RoomComponent implements OnInit {

  @Input() homeId: number;
  @Input() room: Room;

  constructor() { }

  ngOnInit() {
  }

}

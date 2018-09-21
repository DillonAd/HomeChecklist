import { Room } from './../interfaces/room';
import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-room',
  templateUrl: './room.component.html',
  styleUrls: ['./room.component.css']
})
export class RoomComponent implements OnInit {

  @Input() homeId: number;
  @Input() room: Room;
  @Output() roomCreated: EventEmitter<Room> = new EventEmitter();
  @Output() roomChanged: EventEmitter<Room> = new EventEmitter();

  constructor() { }

  ngOnInit() {
  }

  createRoom() {
    this.roomCreated.emit(this.room);
  }

  updateRoom() {
    this.roomChanged.emit(this.room);
  }
}

import { Component, OnInit, Input } from '@angular/core';
import { Observable } from 'rxjs';
import { RoomService } from '../services/room.service';
import { Room } from '../interfaces/room';

@Component({
  selector: 'app-room-list',
  templateUrl: './room-list.component.html',
  styleUrls: ['./room-list.component.css']
})
export class RoomListComponent implements OnInit {

  @Input() homeId: number;

  private selectedRoom: Room;

  public rooms: Observable<Room[]>;

  constructor(private roomService: RoomService) {
    this.refeshRooms();
  }

  ngOnInit() {
  }

  refeshRooms() {
    this.rooms = this.roomService.getRooms(this.homeId);
  }

  newRoom() {
    this.selectedRoom = { Id: null, Name: null, HomeId: this.homeId };
  }

  createRoom(room: Room) {
    this.roomService.createRoom(room);
    this.refeshRooms();
  }

  updateRoom(room: Room) {
    this.roomService.updateRoom(room);
    this.refeshRooms();
  }
}

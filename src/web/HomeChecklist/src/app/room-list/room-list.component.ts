import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { RoomService } from '../services/room.service';
import { Room } from '../interfaces/room'

@Component({
  selector: 'app-room-list',
  templateUrl: './room-list.component.html',
  styleUrls: ['./room-list.component.css']
})
export class RoomListComponent implements OnInit {

  public rooms: Observable<Room[]>;

  constructor(private roomService: RoomService) { }

  ngOnInit() {
  }

}

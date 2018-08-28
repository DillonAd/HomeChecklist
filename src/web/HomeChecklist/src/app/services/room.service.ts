import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { Room } from '../interfaces/room';

@Injectable({
  providedIn: 'root'
})
//RoomService... Get it... ;-)
export class RoomService {

  private url: string = environment.baseUrl + '/api/room/';

  constructor(private http: HttpClient) { }

  getRoom(id: number): Observable<Room> {
    return this.http.get<Room>(this.url + id);
  }

  getRooms(): Observable<Room[]> {
    return this.http.get<Room[]>(this.url);
  }

  createRoom(room: Room) {
    this.http.post(this.url, room);
  }

  updateRoom(room: Room) {
    this.http.put(this.url, room);
  }

  deleteRoom(roomId: number) {
    this.http.delete(this.url + roomId);
  }
}

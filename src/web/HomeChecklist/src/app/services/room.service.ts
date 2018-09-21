import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { Room } from '../interfaces/room';

@Injectable({
  providedIn: 'root'
})
export class RoomService {

  private url: string = environment.baseUrl + '/api/room/';

  constructor(private http: HttpClient) { }

  getRoom(id: number, homeId: number): Observable<Room> {
    return this.http.get<Room>(this.url + id);
  }

  getRooms(homeId: number): Observable<Room[]> {
    return this.http.get<Room[]>(this.url);
  }

  createRoom(room: Room) {
    this.http.post(this.url, room).subscribe();
  }

  updateRoom(room: Room) {
    this.http.put(this.url, room).subscribe();
  }

  deleteRoom(roomId: number) {
    this.http.delete(this.url + roomId).subscribe();
  }
}

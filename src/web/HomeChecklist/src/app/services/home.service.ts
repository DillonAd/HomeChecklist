import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { Home } from '../classes/home';

@Injectable({
  providedIn: 'root'
})
export class HomeService {

  private url: string = environment.baseUrl + '/api/home/';

  constructor(private http: HttpClient) { }

  getHome(id: number): Observable<Home> {
    return this.http.get<Home>(this.url + id);
  }

  getHomes(): Observable<Home[]> {
    return this.http.get<Home[]>(this.url);
  }

  createHome(home: Home) {
    this.http.post(this.url, home);
  }

  updateHome(home: Home) {
    this.http.put(this.url + home.Id, home);
  }

  deleteHome(homeId: number) {
    this.http.delete(this.url + homeId);
  }
}

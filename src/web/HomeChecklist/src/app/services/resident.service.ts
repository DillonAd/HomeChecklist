import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { Resident } from '../interfaces/resident';

@Injectable({
  providedIn: 'root'
})
export class ResidentService {

  private url: string = environment.baseUrl + '/api/resident/';

  constructor(private http: HttpClient) { }

  getResident(id: number): Observable<Resident> {
    return this.http.get<Resident>(this.url + id);
  }

  getResidents(): Observable<Resident[]> {
    return this.http.get<Resident[]>(this.url);
  }

  createResident(resident: Resident) {
    this.http.post(this.url, resident);
  }

  updateResident(resident: Resident) {
    this.http.put(this.url + resident.Id, resident);
  }

  deleteResident(residentId: number) {
    this.http.delete(this.url + residentId);
  }
}

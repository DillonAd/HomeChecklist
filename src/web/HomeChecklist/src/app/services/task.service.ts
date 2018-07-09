import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class TaskService {

  private url: string = environment.baseUrl + "/api/task/";

  constructor(private http: HttpClient) { }

  getTask(id: number) : Observable<Task> {
    return this.http.get<Task>(this.url + id);
  }

  getTasks() : Observable<Task[]> {
    return this.http.get<Task[]>(this.url);
  }
}

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { Task } from '../interfaces/task';

@Injectable({
  providedIn: 'root'
})
export class TaskService {

  private url: string = environment.baseUrl + '/api/taskitem/';

  constructor(private http: HttpClient) { }

  getTasks(roomId: number): Observable<Task[]> {
    return this.http.get<Task[]>(this.url + roomId);
  }

  createTask(task: Task) {
    this.http.post(this.url, task);
  }

  updateTask(task: Task) {
    this.http.put(this.url, task);
  }

  completeTask(taskId: number) {
    this.http.delete(this.url + taskId);
  }
}

import { Component, OnInit } from '@angular/core';
import { TaskService } from '../services/task.service';
import { Task } from '../interfaces/task';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.css']
})
export class TaskListComponent implements OnInit {

  public tasks : Observable<Task[]>;

  constructor(taskService: TaskService) {
    this.tasks = taskService.getTasks();
  }

  ngOnInit() {
  }
}

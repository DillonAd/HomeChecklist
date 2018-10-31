import { Component, OnInit, Input } from '@angular/core';
import { TaskService } from '../services/task.service';
import { Task } from '../interfaces/task';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.css']
})
export class TaskListComponent implements OnInit {

  @Input() roomId: number;
  
  public tasks: Observable<Task[]>;

  constructor(private taskService: TaskService) {
  }

  ngOnInit() {
    this.refreshTasks();
  }

  refreshTasks() {
    this.tasks = this.taskService.getTasks(this.roomId);
  }
}

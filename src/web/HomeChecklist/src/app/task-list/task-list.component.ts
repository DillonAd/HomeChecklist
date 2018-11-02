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

  private selectedTask: Task;
  
  private tasks: Observable<Task[]>;

  constructor(private taskService: TaskService) { }

  ngOnInit() {
    this.refreshTasks();
  }

  createTask() {
    this.selectedTask = { id: null, name: null, lastDone: null, interval: null, roomId: this.roomId }
  }

  refreshTasks() {
    this.tasks = this.taskService.getTasks(this.roomId);
  }

  taskCreated(task: Task) {
    this.taskService.createTask(task);
  }

  taskUpdated(task: Task) {
    this.taskService.updateTask(task);
    this.refreshTasks();
  }

  taskCompleted(task: Task) {
    this.taskService.completeTask(task.id);
    this.refreshTasks();
  }
}

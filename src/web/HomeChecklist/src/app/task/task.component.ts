import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Task } from '../interfaces/task';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.css']
})
export class TaskComponent implements OnInit {

  @Input() task: Task;

  @Output() taskCreated: EventEmitter<Task> = new EventEmitter();
  @Output() taskChanged: EventEmitter<Task> = new EventEmitter();

  private edit: boolean;

  constructor() { }

  ngOnInit() {
    this.edit = false;
  }

  startEdit() {
    this.edit = true;
  }

  createTask() {
    this.edit = false;
    this.taskCreated.emit(this.task);
  }

  updateTask() {
    this.edit = false;
    this.taskChanged.emit(this.task);
  }
}

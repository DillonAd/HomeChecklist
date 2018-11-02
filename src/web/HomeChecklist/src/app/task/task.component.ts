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

  constructor() { }

  ngOnInit() {
  }

  created() {
    this.taskCreated.emit(this.task);
  }

  changed() {
    this.taskChanged.emit(this.task);
  }
}

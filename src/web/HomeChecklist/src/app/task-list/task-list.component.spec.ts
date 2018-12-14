import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import {
  MatCard,
  MatCheckbox,
  MatFormField,
  MatIcon,
  MatList,
  MatListItem,
  MatRipple } from '@angular/material';
import { PortalModule } from '@angular/cdk/portal';

import { TaskComponent } from '../task/task.component';
import { TaskListComponent } from './task-list.component';

describe('TaskListComponent', () => {
  let component: TaskListComponent;
  let fixture: ComponentFixture<TaskListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [
        FormsModule,
        HttpClientModule,
        PortalModule
      ],
      declarations: [
        MatCard,
        MatCheckbox,
        MatFormField,
        MatIcon,
        MatList,
        MatListItem,
        MatRipple,
        TaskComponent,
        TaskListComponent
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TaskListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

@Component({
  selector: 'app-task',
  template: ''
})
class MockTaskComponent {
}
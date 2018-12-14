import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import {
  MatAccordion,
  MatCard,
  MatCardContent,
  MatCardHeader,
  MatCheckbox,
  MatExpansionPanel,
  MatExpansionPanelHeader,
  MatExpansionPanelTitle,
  MatFormField,
  MatIcon,
  MatList,
  MatListItem,
  MatRipple } from '@angular/material';
import { PortalModule } from '@angular/cdk/portal';

import { RoomListComponent } from './room-list.component';
import { RoomComponent } from '../room/room.component';
import { TaskComponent } from '../task/task.component';
import { TaskListComponent } from '../task-list/task-list.component';

describe('RoomListComponent', () => {
  let component: RoomListComponent;
  let fixture: ComponentFixture<RoomListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [ 
        FormsModule,
        HttpClientModule,
        PortalModule
      ],
      declarations: [
        MatAccordion,
        MatCard,
        MatCardContent,
        MatCardHeader,
        MatCheckbox,
        MatExpansionPanel,
        MatExpansionPanelHeader,
        MatExpansionPanelTitle,
        MatFormField,
        MatIcon,
        MatList,
        MatListItem,
        MatRipple,
        RoomComponent,
        RoomListComponent,
        TaskComponent,
        TaskListComponent
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RoomListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

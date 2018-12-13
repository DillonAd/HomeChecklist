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
  MatExpansionPanelContent,
  MatExpansionPanelHeader,
  MatExpansionPanelTitle,
  MatList,
  MatListItem,
  MatFormField,
  MatIcon,
  MatRipple } from '@angular/material';
import { PortalModule } from '@angular/cdk/portal';

import { HomeComponent } from './home.component';
import { RoomComponent } from '../room/room.component';
import { RoomListComponent } from '../room-list/room-list.component';
import { TaskComponent } from '../task/task.component';
import { TaskListComponent } from '../task-list/task-list.component';

describe('HomeComponent', () => {
  let component: HomeComponent;
  let fixture: ComponentFixture<HomeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [ 
        FormsModule,
        HttpClientModule,
        PortalModule
      ],
      declarations: [
        HomeComponent,
        MatAccordion,
        MatCard,
        MatCardContent,
        MatCardHeader,
        MatCheckbox,
        MatExpansionPanel,
        MatExpansionPanelContent,
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
    fixture = TestBed.createComponent(HomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

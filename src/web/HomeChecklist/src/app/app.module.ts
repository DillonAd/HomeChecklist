import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http'
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {
  MatCardModule,
  MatInputModule,
  MatListModule,
  MatIconModule,
  MatButtonModule,
  MatExpansionModule,
  MatCheckboxModule } from '@angular/material';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { HomeListComponent } from './home-list/home-list.component';
import { HomeService } from './services/home.service';
import { ResidentService } from './services/resident.service';
import { RoomService } from './services/room.service';
import { TaskComponent } from './task/task.component';
import { TaskListComponent } from './task-list/task-list.component';
import { TaskService } from './services/task.service';
import { RoomListComponent } from './room-list/room-list.component';
import { RoomComponent } from './room/room.component';

@NgModule({
  declarations: [
    AppComponent,
    TaskListComponent,
    TaskComponent,
    HomeListComponent,
    HomeComponent,
    RoomListComponent,
    RoomComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatCardModule,
    MatInputModule,
    MatListModule,
    MatIconModule,
    MatExpansionModule,
    MatCheckboxModule
  ],
  providers: [
    HomeService,
    ResidentService,
    RoomService,
    TaskService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

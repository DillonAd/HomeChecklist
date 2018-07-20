import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http'
import { HttpClientModule } from '@angular/common/http';

import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { HomeListComponent } from './home-list/home-list.component';
import { HomeService } from './services/home.service';
import { ResidentService } from './services/resident.service';
import { RoomService } from './services/room.service';
import { TaskComponent } from './task/task.component';
import { TaskListComponent } from './task-list/task-list.component';
import { TaskService } from './services/task.service';

@NgModule({
  declarations: [
    AppComponent,
    TaskListComponent,
    TaskComponent,
    HomeListComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    HttpClientModule
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

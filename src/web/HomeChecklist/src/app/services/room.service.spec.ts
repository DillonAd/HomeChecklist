import { inject, TestBed } from '@angular/core/testing';
import { HttpClientModule } from '@angular/common/http';

import { RoomService } from './room.service';

describe('RoomService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientModule],
      providers: [RoomService]
    });
  });

  it('should be created', inject([RoomService], (service: RoomService) => {
    expect(service).toBeTruthy();
  }));
});

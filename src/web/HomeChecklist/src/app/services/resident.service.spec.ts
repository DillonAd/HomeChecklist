import { HttpClientModule } from '@angular/common/http';
import { inject, TestBed } from '@angular/core/testing';

import { ResidentService } from './resident.service';

describe('ResidentService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientModule],
      providers: [ResidentService]
    });
  });

  it('should be created', inject([ResidentService], (service: ResidentService) => {
    expect(service).toBeTruthy();
  }));
});

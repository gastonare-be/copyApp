import { TestBed, inject } from '@angular/core/testing';

import { ReparacionesService } from './reparaciones.service';

describe('ReparacionesService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ReparacionesService]
    });
  });

  it('should be created', inject([ReparacionesService], (service: ReparacionesService) => {
    expect(service).toBeTruthy();
  }));
});

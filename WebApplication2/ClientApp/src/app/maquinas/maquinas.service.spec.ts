import { TestBed, inject } from '@angular/core/testing';

import { MaquinasService } from './maquinas.service';

describe('MaquinasService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [MaquinasService]
    });
  });

  it('should be created', inject([MaquinasService], (service: MaquinasService) => {
    expect(service).toBeTruthy();
  }));
});

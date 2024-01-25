import { TestBed } from '@angular/core/testing';

import { MateriiService } from './materii.service';

describe('MateriiService', () => {
  let service: MateriiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MateriiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

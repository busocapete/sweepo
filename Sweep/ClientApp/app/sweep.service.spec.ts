import { TestBed } from '@angular/core/testing';

import { SweepService } from './sweep.service';

describe('SweepService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SweepService = TestBed.get(SweepService);
    expect(service).toBeTruthy();
  });
});

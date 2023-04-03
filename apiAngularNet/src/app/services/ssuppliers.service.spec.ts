import { TestBed } from '@angular/core/testing';

import { SSuppliersService } from './ssuppliers.service';

describe('SSuppliersService', () => {
  let service: SSuppliersService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SSuppliersService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

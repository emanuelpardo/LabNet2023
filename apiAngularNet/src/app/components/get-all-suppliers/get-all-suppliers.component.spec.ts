import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetAllSuppliersComponent } from './get-all-suppliers.component';

describe('GetAllSuppliersComponent', () => {
  let component: GetAllSuppliersComponent;
  let fixture: ComponentFixture<GetAllSuppliersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetAllSuppliersComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GetAllSuppliersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

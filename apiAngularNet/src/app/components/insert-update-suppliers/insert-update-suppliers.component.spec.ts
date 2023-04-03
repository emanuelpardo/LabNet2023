import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InsertUpdateSuppliersComponent } from './insert-update-suppliers.component';

describe('InsertUpdateSuppliersComponent', () => {
  let component: InsertUpdateSuppliersComponent;
  let fixture: ComponentFixture<InsertUpdateSuppliersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InsertUpdateSuppliersComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InsertUpdateSuppliersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CustomerProfileFormComponent } from './customer-profile-form.component';

describe('CustomerProfileFormComponent', () => {
  let component: CustomerProfileFormComponent;
  let fixture: ComponentFixture<CustomerProfileFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CustomerProfileFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CustomerProfileFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

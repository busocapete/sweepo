import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SweepsAdminComponent } from './sweeps-admin.component';

describe('SweepsAdminComponent', () => {
  let component: SweepsAdminComponent;
  let fixture: ComponentFixture<SweepsAdminComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SweepsAdminComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SweepsAdminComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

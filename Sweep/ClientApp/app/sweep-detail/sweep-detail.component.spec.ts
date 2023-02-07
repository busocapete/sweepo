import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SweepDetailComponent } from './sweep-detail.component';

describe('SweepDetailComponent', () => {
  let component: SweepDetailComponent;
  let fixture: ComponentFixture<SweepDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SweepDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SweepDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

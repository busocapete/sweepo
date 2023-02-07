import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VirtualMatchPlayComponent } from './virtual-match-play.component';

describe('VirtualMatchPlayComponent', () => {
  let component: VirtualMatchPlayComponent;
  let fixture: ComponentFixture<VirtualMatchPlayComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VirtualMatchPlayComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VirtualMatchPlayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EnterScoreCardComponent } from './enter-score-card.component';

describe('EnterScoreCardComponent', () => {
  let component: EnterScoreCardComponent;
  let fixture: ComponentFixture<EnterScoreCardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EnterScoreCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EnterScoreCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

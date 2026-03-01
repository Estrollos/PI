import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecoverPass } from './recover-pass';

describe('RecoverPass', () => {
  let component: RecoverPass;
  let fixture: ComponentFixture<RecoverPass>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RecoverPass]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RecoverPass);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

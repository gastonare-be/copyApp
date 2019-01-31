import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ReparacionesFormComponent } from './reparaciones-form.component';

describe('ReparacionesFormComponent', () => {
  let component: ReparacionesFormComponent;
  let fixture: ComponentFixture<ReparacionesFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReparacionesFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReparacionesFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

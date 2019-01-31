import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DatatablesClientesComponent } from './datatables-clientes.component';

describe('DatatablesClientesComponent', () => {
  let component: DatatablesClientesComponent;
  let fixture: ComponentFixture<DatatablesClientesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DatatablesClientesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DatatablesClientesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

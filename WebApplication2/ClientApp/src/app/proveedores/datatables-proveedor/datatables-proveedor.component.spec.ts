import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DatatablesProveedorComponent } from './datatables-proveedor.component';

describe('DatatablesProveedorComponent', () => {
  let component: DatatablesProveedorComponent;
  let fixture: ComponentFixture<DatatablesProveedorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DatatablesProveedorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DatatablesProveedorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

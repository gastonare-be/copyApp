import { Component, OnInit } from '@angular/core';
import { IProveedor } from '../proveedor';
import { ProveedoresService } from '../proveedores.service';

@Component({
  selector: 'app-datatables-proveedor',
  templateUrl: './datatables-proveedor.component.html',
  styleUrls: ['./datatables-proveedor.component.css']
})
export class DatatablesProveedorComponent implements OnInit {
  proveedores: IProveedor[];

  constructor(private proveedoresService: ProveedoresService) { }

  ngOnInit() {
    this.list();
  }

  list() {
    this.proveedoresService.getProveedor()
      .subscribe(proveedoresDesdeWS => this.proveedores = proveedoresDesdeWS,
        error => console.error(error));
  }
}

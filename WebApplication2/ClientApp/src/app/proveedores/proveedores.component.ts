import { Component, OnInit } from '@angular/core';
import { ProveedoresService } from './proveedores.service';
import { IProveedor } from './proveedor';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-proveedores',
  templateUrl: './proveedores.component.html',
  styleUrls: ['./proveedores.component.css']
})
export class ProveedoresComponent implements OnInit {

  proveedores: IProveedor[];
  proveedorId: number;
  constructor(private proveedoresService: ProveedoresService, private router: Router,
    private activateRoute: ActivatedRoute) { }

  ngOnInit() {
    this.list();
  }

  list() {
    this.proveedoresService.getProveedor()
      .subscribe(proveedoresDesdeWS => this.proveedores = proveedoresDesdeWS,
      error => console.error(error));
  }

  obtenerId(): number {

    this.activateRoute.params.subscribe(params => {
      if (params['id'] == undefined) {
        return;
      }

      this.proveedorId = params['id'];
    });
    return this.proveedorId;
  }

  delete(proveedor: IProveedor) {
    this.proveedoresService.delete(proveedor.id.toString())
      .subscribe(proveedor => this.list(),
        error => console.error(error));
  }

}

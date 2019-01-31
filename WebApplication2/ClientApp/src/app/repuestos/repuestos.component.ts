import { Component, OnInit } from '@angular/core';
import { IRepuesto } from './repuesto';
import { RepuestosService } from './repuestos.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-repuestos',
  templateUrl: './repuestos.component.html',
  styleUrls: ['./repuestos.component.css']
})
export class RepuestosComponent implements OnInit {

  repuestos: IRepuesto[];
  repuestoId: number;
  constructor(private repuestosService: RepuestosService, private router: Router,
    private activateRoute: ActivatedRoute) { }

  ngOnInit() {
  }

  list() {
    this.repuestosService.getRepuesto()
      .subscribe(proveedoresDesdeWS => this.repuestos = proveedoresDesdeWS,
        error => console.error(error));
  }

  obtenerId(): number {

    this.activateRoute.params.subscribe(params => {
      if (params['id'] == undefined) {
        return;
      }

      this.repuestoId = params['id'];
    });
    return this.repuestoId;
  }

  delete(repuesto: IRepuesto) {
    this.repuestosService.delete(repuesto.id.toString())
      .subscribe(proveedor => this.list(),
        error => console.error(error));
  }
}

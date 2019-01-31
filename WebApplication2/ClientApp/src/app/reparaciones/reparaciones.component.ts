import { Component, OnInit } from '@angular/core';
import { IReparacion } from './reparaciones';
import { ReparacionesService } from './reparaciones.service';
import { Router, ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-reparaciones',
  templateUrl: './reparaciones.component.html',
  styleUrls: ['./reparaciones.component.css']
})
export class ReparacionesComponent implements OnInit {

  reparaciones: IReparacion[];
  maquinaId: number;
  constructor(private reparacionesService: ReparacionesService, private router: Router,
    private activateRoute: ActivatedRoute) { }

  ngOnInit() {
    this.listarReparacion();
    this.obtenerId();
  }


  obtenerId(): number{

    this.activateRoute.params.subscribe(params => {
      if (params['id'] == undefined) {
        return;
      }

      this.maquinaId = params['id'];
    });
    return this.maquinaId;
  }

  delete(reparacion: IReparacion) {
    this.reparacionesService.deleteReparacion(reparacion.id.toString())
           .subscribe(reparacion => this.listarReparacion(),
              error => console.error(error));  
  }

  listarReparacion() {
    this.reparacionesService.getreparacionesId(this.obtenerId())
      .subscribe(reparacionesDesdeWS => this.reparaciones = reparacionesDesdeWS,
        error => console.error(error));
  }
}

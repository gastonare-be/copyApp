import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { IReparacion } from '../reparaciones';
import { ReparacionesService } from '../reparaciones.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-reparaciones-form',
  templateUrl: './reparaciones-form.component.html',
  styleUrls: ['./reparaciones-form.component.css']
})
export class ReparacionesFormComponent implements OnInit {

  reparacion: IReparacion;
  constructor(private fb: FormBuilder,
    private reparacionService: ReparacionesService,
    private router: Router,
    private activateRoute: ActivatedRoute) { }

  maquinaId: number;
  modoEdicion: boolean = false;
  reparacionId: number;
  formGroup: FormGroup;

  ngOnInit() {
    this.formGroup = this.fb.group({
      id:'0',
      fecha:'',
      contador: '',
      descripcion: '',
      lim_Mod:'',
      lim_Ur:'',
      lim_Op: '',
     // ReparacionId: this.reparacionId != null ? this.reparacionId : 0

    })
  }

  save() {
    let reparacion: IReparacion = Object.assign({}, this.formGroup.value);
    reparacion.MaquinasId = this.obtenerId();
    console.table(reparacion);

    if (this.modoEdicion) {
      //editar el registro
    //  reparacion.id = this.reparacionId;
    //  this.clienteservice.updateCliente(cliente)
    //    .subscribe(cliente => this.borrarMaquinas(),
    //      error => console.error(error));
    } else {
      //agregar el registro

     
      this.reparacionService.createReparacion(reparacion)
        .subscribe(cliente => this.onSaveSucces(),
          error => console.error(error));
    }
  }

  onSaveSucces() {
    this.router.navigate(["/reparaciones/" + this.maquinaId])

  }

  obtenerId(): number {

    this.activateRoute.params.subscribe(params => {
      if (params['id'] == undefined) {
        return;
      }

      this.maquinaId = params['id'];
    });
    return this.maquinaId;
  }
}

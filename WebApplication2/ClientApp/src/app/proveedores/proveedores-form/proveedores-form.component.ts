import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ProveedoresService } from '../proveedores.service';
import { FormBuilder, FormGroup } from '@angular/forms';
import { IProveedor } from '../proveedor';

@Component({
  selector: 'app-proveedores-form',
  templateUrl: './proveedores-form.component.html',
  styleUrls: ['./proveedores-form.component.css']
})
export class ProveedoresFormComponent implements OnInit {

  formGroup: FormGroup;

  constructor(private fb: FormBuilder,private proveedoresService: ProveedoresService, private router: Router,
    private activateRoute: ActivatedRoute) { }

  ngOnInit() {
    this.formGroup = this.fb.group({
      nombre: '',
      fechaNacimiento: '',
      maquinas: this.fb.array([])

    });
  }

  save() {
    let proveedor: IProveedor = Object.assign({}, this.formGroup.value);
    console.table(proveedor);

    //if (this.modoEdicion) {
    //  //editar el registro
    //  cliente.id = this.clienteId;
    //  this.clienteservice.updateCliente(cliente)
    //    .subscribe(cliente => this.borrarMaquinas(),
    //      error => console.error(error));
    //} else {
      //agregar el registro

    this.proveedoresService.insert(proveedor)
         .subscribe(proveedor => this.onSaveSucces(),
          error => console.error(error));
    //}
  }

  onSaveSucces() {
    this.router.navigate(["/proveedores"])
  }

}

import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormGroup, FormArray } from '@angular/forms';
import { ICliente } from '../cliente';
import { ClientesService } from '../clientes.service';
import { error } from 'util';
import { Router, ActivatedRoute } from '@angular/router';
import { DatePipe } from '@angular/common';
import { MaquinasService } from '../../maquinas/maquinas.service';
import { IMaquina } from '../../maquinas/maquina';

@Component({
  selector: 'app-clientes-form',
  templateUrl: './clientes-form.component.html',
  styleUrls: ['./clientes-form.component.css']
})
export class ClientesFormComponent implements OnInit {

  cliente: ICliente;


  constructor(private fb: FormBuilder,
    private clienteservice: ClientesService,
    private maquinasService: MaquinasService,
    private router: Router,
    private activateRoute: ActivatedRoute) { }

  modoEdicion: boolean = false;
  formGroup: FormGroup;
  clienteId: number;
  maquinasABorrar: number[] = [];


  ngOnInit() {
    this.formGroup = this.fb.group({
      nombre: '',
      fechaNacimiento: '',
      maquinas: this.fb.array([])

    });

   

    this.activateRoute.params.subscribe(params => {
      if (params['id'] == undefined) {
        return;
      }

      this.modoEdicion = true;

      this.clienteId = params['id'];

      this.clienteservice.getCliente_id(this.clienteId.toString())
        .subscribe(cliente => this.cargarFormulario(cliente),
          error => this.router.navigate(["/Clientes"]));
    });

  }
  agregarMaquina() {
    let maquinaArr = this.formGroup.get('maquinas') as FormArray;
    let maquinaFG = this.construirMaquina();
    maquinaArr.push(maquinaFG);
  }
  construirMaquina() {
    return this.fb.group({
      id: '0',
      serial: '',
      marca: '',
      modelo: '',
      contador: '',
      ClienteId: this.clienteId != null ? this.clienteId : 0

    });
  }

  removerMaquina(index: number) {
    let maquinas = this.formGroup.get('maquinas') as FormArray;
    let maquinasRemover = maquinas.at(index) as FormGroup;
    if (maquinasRemover.controls['id'].value != '0') {
      this.maquinasABorrar.push(<number>maquinasRemover.controls['id'].value);
    }
    maquinas.removeAt(index);
  }

  cargarFormulario(cliente: ICliente) {
    var dp = new DatePipe(navigator.language);
    var format = "yyyy-MM-dd";

    //pasa valores al formulario y formate la fecha
    this.formGroup.patchValue({
      nombre: cliente.nombre,
      fechaNacimiento: cliente.fechaNacimiento//dp.transform(cliente.fechaNacimiento, format)
     
    });
    let maquinas = this.formGroup.controls['maquinas'] as FormArray;
    cliente.maquinas.forEach(maquina => {
      let maquinasFG = this.construirMaquina();
      maquinasFG.patchValue(maquina);
      maquinas.push(maquinasFG);

    });
  }
  save() {
    let cliente: ICliente = Object.assign({}, this.formGroup.value);
    console.table(cliente);

    if (this.modoEdicion) {
      //editar el registro
      cliente.id = this.clienteId;
      this.clienteservice.updateCliente(cliente)
        .subscribe(cliente => this.borrarMaquinas(),
          error => console.error(error));
    } else {
      //agregar el registro


      this.clienteservice.createCliente(cliente)
        .subscribe(cliente => this.onSaveSucces(),
          error => console.error(error));
    }
  }

  borrarMaquinas() {
    if (this.maquinasABorrar.length === 0) {
      this.onSaveSucces();
      return;
    }

    this.maquinasService.deleteMaquinas(this.maquinasABorrar)
      .subscribe(() => this.onSaveSucces(),
        error => console.error(error));
  }

  onSaveSucces() {
    this.router.navigate(["/Clientes"])
  }

 
}

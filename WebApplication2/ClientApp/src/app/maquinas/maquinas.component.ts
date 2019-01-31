import { Component, OnInit } from '@angular/core';
import { IMaquina } from './maquina';
import { MaquinasService } from './maquinas.service';
import { error } from 'util';
import { ClientesService } from '../clientes/clientes.service';
import { Router, ActivatedRoute } from '@angular/router';
import { ICliente } from '../clientes/cliente';
import { forEach } from '@angular/router/src/utils/collection';

@Component({
  selector: 'app-maquinas',
  templateUrl: './maquinas.component.html',
  styleUrls: ['./maquinas.component.css']
})
export class MaquinasComponent implements OnInit {

  maquinas: IMaquina[];
  cliente: ICliente;
  clienteId: string;
  maquina: IMaquina

  constructor(private maquinaService: MaquinasService, private clienteService: ClientesService, private router: Router,
    private activateRoute: ActivatedRoute) { }

  ngOnInit() {
    this.cargarPorId();
  }


  cargarPorId() {
    this.activateRoute.params.subscribe(params => {
      if (params['id'] == undefined) {
        return;
      }

      this.clienteId = params['id'];

      this.buscarmaquina(this.clienteId);
      this.clienteService.getCliente_id(this.clienteId)
        .subscribe(clienteDesdeWS => this.cliente = clienteDesdeWS,
          error => console.error(error))

    });

    
  }

  

  buscarmaquina(clienteId: string) {
    this.maquinaService.getmaquina(clienteId)
      .subscribe(maquinasDesdeWS => this.maquinas = maquinasDesdeWS,
        error => console.error(error))
    }

  delete(cliente: ICliente) {
    this.maquinaService.deleteMaquina(cliente.id)
      .subscribe(maquinas => this.buscarmaquina(cliente.id.toString()),
        error => console.error(error))

  }
}

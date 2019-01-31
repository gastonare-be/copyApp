import { Component, OnInit } from '@angular/core';
import { ICliente } from './cliente';
import { ClientesService } from './clientes.service';
import { error } from 'util'
import { forEach } from '@angular/router/src/utils/collection';
@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.css']
})
export class ClientesComponent implements OnInit {

  clientes: ICliente[];
  filtrados: ICliente[];
  filtro: string = "m";

  constructor(private clientesService: ClientesService) { }

  ngOnInit() {
    this.cargarData();
  }
  delete(cliente: ICliente) {
    this.clientesService.deleteCliente(cliente.id.toString())
      .subscribe(cliente => this.cargarData(),
        error => console.error(error));  
  }
  cargarData() {
    this.clientesService.getCliente()
      .subscribe(clientesDesdeWS => this.clientes = clientesDesdeWS,
        error => console.error(error));
  }
  filter() {
    this.clientesService.filterByCliente(this.filtro)
      .subscribe(filtradosDesdeWS => this.clientes = filtradosDesdeWS,
       error => console.error(error));
   }
}

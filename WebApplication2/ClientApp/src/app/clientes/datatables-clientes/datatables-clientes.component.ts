import { Component, OnInit } from '@angular/core';
import { ICliente } from '../cliente';
import { ClientesService } from '../clientes.service';

@Component({
  selector: 'app-datatables-clientes',
  templateUrl: './datatables-clientes.component.html',
  styleUrls: ['./datatables-clientes.component.css']
})
export class DatatablesClientesComponent implements OnInit {

  clientes: ICliente[];
  constructor(private clientesService: ClientesService) { }

  ngOnInit() {
    this.cargarData();
  }

  cargarData() {
    this.clientesService.getCliente()
      .subscribe(clientesDesdeWS => this.clientes = clientesDesdeWS,
        error => console.error(error));
  }

}

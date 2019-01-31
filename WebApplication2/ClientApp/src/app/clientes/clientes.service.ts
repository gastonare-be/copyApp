import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { ICliente } from './cliente';

@Injectable()
export class ClientesService {

  private apiURL = this.baseUrl + "api/Clientes";
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getCliente(): Observable<ICliente[]> {
    return this.http.get<ICliente[]>(this.apiURL);
  }

  createCliente(cliente: ICliente): Observable<ICliente> {
    return this.http.post<ICliente>(this.apiURL, cliente);
  }

  getCliente_id(clienteId: string): Observable<ICliente> {
    let params = new HttpParams().set('incluirMaquinas', "true");
    return this.http.get<ICliente>(this.apiURL + '/' + clienteId, { params: params });
  }

  updateCliente(cliente: ICliente): Observable<ICliente> {
    return this.http.put<ICliente>(this.apiURL + "/" + cliente.id.toString(), cliente);
  }

  deleteCliente(clienteId: string): Observable<ICliente> {
    return this.http.delete<ICliente>(this.apiURL + "/" + clienteId);
  }

  filterByCliente(filter: string): Observable<ICliente[]> {
    return this.http.post<ICliente[]>(this.apiURL + "/Post/filtro", filter);
  }
}

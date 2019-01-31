import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { IProveedor } from './proveedor';


@Injectable()
export class ProveedoresService {

  private apiURL = this.baseUrl + "api/Proveedores";
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }


  getProveedor(): Observable<IProveedor[]> {
    return this.http.get<IProveedor[]>(this.apiURL);
  }


  insert(cliente: IProveedor): Observable<IProveedor> {
    return this.http.post<IProveedor>(this.apiURL, cliente);
  }

  update(proveedor: IProveedor): Observable<IProveedor> {
    return this.http.put<IProveedor>(this.apiURL + "/" + proveedor.id.toString(), proveedor);
  }

  delete(proveedorId: string): Observable<IProveedor> {
    return this.http.delete<IProveedor>(this.apiURL + "/" + proveedorId);
  }
}

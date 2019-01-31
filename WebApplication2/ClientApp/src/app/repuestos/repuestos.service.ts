import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { IRepuesto } from './repuesto';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class RepuestosService {
  
  private apiURL = this.baseUrl + "api/Proveedor";
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }


  getRepuesto(): Observable<IRepuesto[]> {
    return this.http.get<IRepuesto[]>(this.apiURL);
  }


  insert(repuesto: IRepuesto): Observable<IRepuesto> {
    return this.http.post<IRepuesto>(this.apiURL, repuesto);
  }

  update(repuesto: IRepuesto): Observable<IRepuesto> {
    return this.http.put<IRepuesto>(this.apiURL + "/" + repuesto.id.toString(), repuesto);
  }

  delete(repuestoId: string): Observable<IRepuesto> {
    return this.http.delete<IRepuesto>(this.apiURL + "/" + repuestoId);
  }
}

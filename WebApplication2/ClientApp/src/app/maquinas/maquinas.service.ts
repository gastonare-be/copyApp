import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { IMaquina } from './maquina';
@Injectable()
export class MaquinasService {


  private apiURL = this.baseUrl + "api/Maquinas";
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  deleteMaquinas(ids: number[]): Observable<void> {
    return this.http.post<void>(this.apiURL + "/delete/list", ids);
  }

  getmaquina(clienteId: string): Observable<IMaquina[]> {
    return this.http.get<IMaquina[]>(this.apiURL + '/' + clienteId);
  }

  deleteMaquina(id: number): Observable<void> {
    return this.http.delete<void>(this.apiURL + "/" + id);
  }
}

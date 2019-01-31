import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { IReparacion } from './reparaciones';

@Injectable()
export class ReparacionesService {

  private apiURL = this.baseUrl + "api/Reps";
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getreparaciones(): Observable<IReparacion[]> {
    return this.http.get<IReparacion[]>(this.apiURL);
  }


  getreparacionesId(maquinaId: number): Observable<IReparacion[]> {
    return this.http.get<IReparacion[]>(this.apiURL + '/' + maquinaId);
  }

  createReparacion(reparacion: IReparacion): Observable<IReparacion> {
    return this.http.post<IReparacion>(this.apiURL, reparacion);
  }

  deleteReparacion(reparacionId: string): Observable<IReparacion> {
    return this.http.delete < IReparacion >(this.apiURL + "/" + reparacionId);
  }
}

import { IReparacion } from "../reparaciones/reparaciones";

export interface IMaquina {

  Id: number;
  serial: number;
  marca: string;
  modelo: string;
  contador: number;
  ClienteId: number;
  reparaciones: IReparacion[]

}

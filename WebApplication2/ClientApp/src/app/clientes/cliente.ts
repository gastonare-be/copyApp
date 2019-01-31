import { IMaquina } from "../maquinas/maquina";

export interface ICliente{
  id: number;
  nombre: string;
  fechaNacimiento: Date;
  maquinas: IMaquina[]
}

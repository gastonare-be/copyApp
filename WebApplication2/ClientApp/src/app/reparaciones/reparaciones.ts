export interface IReparacion {
  id: number;
  fecha: Date;
  contador: number;
  descripcion: string;
  lim_Mod: boolean;
  lim_Ur: boolean;
  lim_Op: boolean;
  MaquinasId: number


}

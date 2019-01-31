export interface IRepuesto {
  id: number;
  codigo: number;
  nombre: string;
  marca: string;
  detalle: string;
  stock: number;
  stochMinimo: number;
  stockIdeal: number;
  precio: number
}

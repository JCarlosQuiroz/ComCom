
export class ICuartoFrio {
  ModalTitle: string;
  BultosParciales: number;
  Clasificacion: number;
  CodEmpaque: number;
  CodEntProduccion: number;
  Embarcado: number;
  Empacado: number;
  Etiqueta: number;
  Fecha: string;
  NomClasificacion: string;
  NomEmpaque: string;
  NomEtiqueta: string;
  NomProducto: string;
  NomTamano: string;
  NomTipo: string;
  ParrillasEmpActivas: number;
  ParrillasEmpParciales: number;
  ParrillasEmpacadas: number;
  Parrillas_Chep: number;
  Producto: number;
  Tamano: number;
  Temporada: string;
  Tipo: number;
  Total: number;

  constructor(
    ModalTitle: string,
    BultosParciales: number,
    Clasificacion: number,
    CodEmpaque: number,
    CodEntProduccion: number,
    Embarcado: number,
    Empacado: number,
    Etiqueta: number,
    Fecha: string,
    NomClasificacion: string,
    NomEmpaque: string,
    NomEtiqueta: string,
    NomProducto: string,
    NomTamano: string,
    NomTipo: string,
    ParrillasEmpActivas: number,
    ParrillasEmpParciales: number,
    ParrillasEmpacadas: number,
    Parrillas_Chep: number,
    Producto: number,
    Tamano: number,
    Temporada: string,
    Tipo: number,
    Total: number,
  ) {
    this.ModalTitle = ModalTitle;
    this.BultosParciales = BultosParciales;
    this.Clasificacion = Clasificacion;
    this.CodEmpaque = CodEmpaque;
    this.CodEntProduccion = CodEntProduccion;
    this.Embarcado = Embarcado;
    this.Empacado = Empacado;
    this.Etiqueta = Etiqueta;
    this.Fecha = Fecha;
    this.NomClasificacion = NomClasificacion;
    this.NomEmpaque = NomEmpaque;
    this.NomEtiqueta = NomEtiqueta;
    this.NomProducto = NomProducto;
    this.NomTamano = NomTamano;
    this.NomTipo = NomTipo;
    this.ParrillasEmpActivas = ParrillasEmpActivas;
    this.ParrillasEmpParciales = ParrillasEmpParciales;
    this.ParrillasEmpacadas = ParrillasEmpacadas;
    this.Parrillas_Chep = Parrillas_Chep;
    this.Producto = Producto;
    this.Tamano = Tamano;
    this.Temporada = Temporada;
    this.Tipo = Tipo;
    this.Total = Total;
  }
  getTotal(ParrillasEmpacadas: number, Empacado: number) {
    return console.log(ParrillasEmpacadas + Empacado);
  }
}

export class ICuartoFrioState {
  items: ICuartoFrio[];
  Empacado: number;
  ParrillasEmpActivas: number;
  ParrillasEmpParciales: number;
  Embarcado: number;
  NomEtiqueta: string;
  Parrillas_Chep: number;
  BultosParciales: number;
  NomProducto: string;
  constructor(
    items: ICuartoFrio[],
    getTotal: number,
    Empacado: number,
    ParrillasEmpActivas: number,
    ParrillasEmpParciales: number,
    Embarcado: number,
    NomEtiqueta: string,
    Parrillas_Chep: number,
    BultosParciales: number,
    NomProducto: string,
  ) {
    this.items = items;
    this.Empacado = Empacado;
    this.ParrillasEmpActivas = ParrillasEmpActivas;
    this.ParrillasEmpParciales = ParrillasEmpParciales;
    this.Embarcado = Embarcado;
    this.NomEtiqueta = NomEtiqueta;
    this.Parrillas_Chep = Parrillas_Chep;
    this.BultosParciales = BultosParciales;
    this.NomProducto = NomProducto;
  }
}


export function Total(state: ICuartoFrio | undefined): number {
  return state ? state.Total : 0;
}



// return (
//   <Stack
//     horizontal
//     wrap
//     tokens={{ padding: '0px 0px 0px 30px', childrenGap: 10 }}
//   >
//     <Stack.Item>
//       <TextField label="Total Bultos" />
//     </Stack.Item>
//     <Stack.Item>
//       <TextField label="Total Parrillas" value={productos.filter(producto => producto.ParrillasEmpActivas  ).reduce((a, b) => a + b.ParrillasEmpActivas, 0)} />
//     </Stack.Item>
//     <Stack.Item>
//       <TextField label="Total Parrillas CHEP" value={productos.filter(producto => producto.NomEtiqueta === 'FRELLO').reduce((a, b) => a + b.Parrillas_Chep, 0)} />
//     </Stack.Item>
//     <Stack.Item>
//       <TextField label="Total Parrillas Embarcadas" value={productos.filter(producto => producto.NomEtiqueta === 'FRELLO').reduce((a, b) => a + b.Embarcado, 0)} />
//     </Stack.Item>
//     <Stack.Item>
//       <TextField label="Total Parrillas Bachas" value={productos.filter(producto => producto.NomEtiqueta === 'FRELLO').reduce((a, b) => a + b.ParrillasEmpParciales, 0)} />
//     </Stack.Item>
//     <Stack.Item>
//       <TextField label="Total Bultos/Bachas" value={productos.filter(producto => producto.NomEtiqueta === 'FRELLO').reduce((a, b) => a + b.BultosParciales, 0)} />
//     </Stack.Item>
//     </Stack>
// )
// } : undefined}


// getTabId?: (itemKey: string, index: number) => string;
// /**
//  * Props passed to the `FocusZone` component used as the root of `Pivot`.
//  */


using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01TIEMAIRSERRPM
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string U_SO1_SERVICIOWEB { get; set; } = null!;
        public int? U_SO1_CODIGOPRODUCTO { get; set; }
        public string? U_SO1_NOMBREPRODUCTO { get; set; }
        public short? U_SO1_CATEGORIA { get; set; }
        public string U_SO1_TIPOCATEGORIA { get; set; } = null!;
        public string? U_SO1_ARTICULOSBO { get; set; }
        public decimal? U_SO1_MONTO { get; set; }
        public decimal? U_SO1_CARGOEXTRA { get; set; }
        public short? U_SO1_LONGITUDREF1 { get; set; }
        public string? U_SO1_DESCRIPCIREF1 { get; set; }
        public short? U_SO1_LONGITUDREF2 { get; set; }
        public string? U_SO1_DESCRIPCIREF2 { get; set; }
        public short? U_SO1_LONGITUDREF3 { get; set; }
        public string? U_SO1_DESCRIPCIREF3 { get; set; }
        public short? U_SO1_ORDENPRIORIDAD { get; set; }
        public string U_SO1_ACTIVO { get; set; } = null!;
        public string? U_SO1_ARTICULOSBOSER { get; set; }
        public string? U_SO1_MONTOFIJO { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01MOVINVENTABIN
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string U_SO1_TIPO { get; set; } = null!;
        public string? U_SO1_NUMEROARTICULO { get; set; }
        public string? U_SO1_ALMACEN { get; set; }
        public int? U_SO1_BIN { get; set; }
        public int? U_SO1_ABSBIN { get; set; }
        public DateTime? U_SO1_FECHA { get; set; }
        public short? U_SO1_HORA { get; set; }
        public string? U_SO1_HORACADENA { get; set; }
        public decimal? U_SO1_CANTIDADENTRAD { get; set; }
        public decimal? U_SO1_CANTIDADSALIDA { get; set; }
        public decimal? U_SO1_CANTIDADPREVIA { get; set; }
    }
}

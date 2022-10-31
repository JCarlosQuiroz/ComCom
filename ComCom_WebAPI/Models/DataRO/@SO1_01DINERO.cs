using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01DINERO
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string U_SO1_TIPO { get; set; } = null!;
        public decimal? U_SO1_MONTO { get; set; }
        public string? U_SO1_COMENTARIOS { get; set; }
        public int? U_SO1_USUARIO { get; set; }
        public string? U_SO1_SUCURSAL { get; set; }
        public string? U_SO1_ESTACION { get; set; }
        public string? U_SO1_HORACADENA { get; set; }
        public DateTime? U_SO1_FECHA { get; set; }
        public short? U_SO1_HORA { get; set; }
        public string? U_SO1_FOLIOCORTEX { get; set; }
        public string? U_SO1_FOLIOFACTGLOB { get; set; }
    }
}

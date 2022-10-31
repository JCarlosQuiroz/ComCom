using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01VENTAPERDIDum
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_SUCURSAL { get; set; }
        public string? U_SO1_ESTACION { get; set; }
        public string? U_SO1_NUMEROARTICULO { get; set; }
        public int? U_SO1_VENDEDOR { get; set; }
        public int? U_SO1_USUARIO { get; set; }
        public DateTime? U_SO1_FECHA { get; set; }
        public short? U_SO1_HORA { get; set; }
        public string? U_SO1_COMENTARIO { get; set; }
        public string? U_SO1_HORACADENA { get; set; }
        public string? U_SO1_PARAMETRO1 { get; set; }
        public string? U_SO1_PARAMETRO2 { get; set; }
        public string? U_SO1_PARAMETRO3 { get; set; }
        public string? U_SO1_PARAMETRO4 { get; set; }
        public string U_SO1_EXISTEARTICULO { get; set; } = null!;
    }
}

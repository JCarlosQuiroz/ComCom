using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01ACTPRECIO
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime? U_SO1_FECHA { get; set; }
        public short? U_SO1_HORA { get; set; }
        public string? U_SO1_HORACADENA { get; set; }
        public string U_SO1_ESTADO { get; set; } = null!;
        public string? U_SO1_USUARIO { get; set; }
        public string? U_SO1_ESTACION { get; set; }
        public string? U_SO1_SUCURSAL { get; set; }
        public DateTime? U_SO1_FECHAAPL { get; set; }
    }
}

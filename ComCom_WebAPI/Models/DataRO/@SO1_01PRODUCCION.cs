using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01PRODUCCION
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_SUCURSAL { get; set; }
        public string? U_SO1_ESTTRABAJO { get; set; }
        public DateTime? U_SO1_FECHA { get; set; }
        public short? U_SO1_HORA { get; set; }
        public string? U_SO1_HORACADENA { get; set; }
        public int? U_SO1_USUARIO { get; set; }
        public string? U_SO1_ARTICULO { get; set; }
        public string? U_SO1_ALMACEN { get; set; }
        public decimal? U_SO1_CANTIDAD { get; set; }
        public string? U_SO1_COMENTARIOS { get; set; }
        public string? U_SO1_DOCUMENTOBASE { get; set; }
        public short? U_SO1_PARTIDABASE { get; set; }
        public string? U_SO1_FOLIOCORTEX { get; set; }
    }
}

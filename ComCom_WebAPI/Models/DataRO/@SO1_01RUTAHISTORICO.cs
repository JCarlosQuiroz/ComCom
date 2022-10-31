using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01RUTAHISTORICO
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? U_SO1_FOLIORUTA { get; set; }
        public short? U_SO1_NUMACTUALIZACI { get; set; }
        public string? U_SO1_ESTADOINICIAL { get; set; }
        public string? U_SO1_ESTADOFINAL { get; set; }
        public DateTime? U_SO1_FECHA { get; set; }
        public short? U_SO1_HORA { get; set; }
        public string? U_SO1_HORACADENA { get; set; }
        public int? U_SO1_USUARIO { get; set; }
        public string? U_SO1_ESTACION { get; set; }
    }
}

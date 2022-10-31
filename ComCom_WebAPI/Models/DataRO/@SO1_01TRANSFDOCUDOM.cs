using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01TRANSFDOCUDOM
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? U_SO1_FOLIODOC { get; set; }
        public DateTime? U_SO1_FECHA { get; set; }
        public short? U_SO1_HORA { get; set; }
        public string? U_SO1_HORACADENA { get; set; }
        public string? U_SO1_SUCDESTINO { get; set; }
        public string? U_SO1_SUCORIGEN { get; set; }
        public int? U_SO1_USUARIO { get; set; }
        public string? U_SO1_ESTACION { get; set; }
        public string U_SO1_TRANSFCOMPL { get; set; } = null!;
        public string U_SO1_ULTIMATRANSFER { get; set; } = null!;
    }
}

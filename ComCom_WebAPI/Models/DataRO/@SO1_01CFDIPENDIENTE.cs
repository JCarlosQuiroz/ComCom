using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CFDIPENDIENTE
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public DateTime U_SO1_FECHA { get; set; }
        public string U_SO1_RFC { get; set; } = null!;
        public decimal U_SO1_MONTO { get; set; }
        public string U_SO1_MONEDA { get; set; } = null!;
        public int U_SO1_HORA { get; set; }
        public string U_SO1_TIPODOCUMENTO { get; set; } = null!;
        public string? U_SO1_NUMCERT { get; set; }
        public string? U_SO1_CADENAORIG { get; set; }
        public string? U_SO1_SELLODIGITAL { get; set; }
        public string? U_SO1_XMLSELLADO { get; set; }
        public string? U_SO1_FOLIOOPER { get; set; }
        public string? U_SO1_FECHATIMB { get; set; }
        public string? U_SO1_SELLOSAT { get; set; }
        public string? U_SO1_NUMCERTSAT { get; set; }
        public string? U_SO1_SERIEFISCAL { get; set; }
        public string U_SO1_ESTATUS { get; set; } = null!;
    }
}

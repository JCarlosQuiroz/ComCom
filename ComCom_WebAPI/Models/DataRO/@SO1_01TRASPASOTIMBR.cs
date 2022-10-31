using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01TRASPASOTIMBR
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_RFC { get; set; }
        public string U_SO1_STATUS { get; set; } = null!;
        public DateTime? U_SO1_FECHA { get; set; }
        public short? U_SO1_HORA { get; set; }
        public int? U_SO1_FOLIOTRASPASO { get; set; }
        public string? U_SO1_PREFIJOTRASPAS { get; set; }
        public string? U_SO1_NUMEROCERT { get; set; }
        public string? U_SO1_CADENAORIGINAL { get; set; }
        public string? U_SO1_SELLODIGITAL { get; set; }
        public string? U_SO1_CFDSELLADO { get; set; }
        public string U_SO1_CFDCREADO { get; set; } = null!;
        public string? U_SO1_SEGUNDO { get; set; }
        public string? U_SO1_FOLIOOPER { get; set; }
        public string? U_SO1_FECHATIMB { get; set; }
        public string? U_SO1_SELLOSAT { get; set; }
        public string? U_SO1_NUMCERTSAT { get; set; }
        public string? U_SO1_LUGEXPEDICION { get; set; }
        public string? U_SO1_REGIMENFISCAL { get; set; }
        public string? U_SO1_CFDIUSOCFDI { get; set; }
    }
}

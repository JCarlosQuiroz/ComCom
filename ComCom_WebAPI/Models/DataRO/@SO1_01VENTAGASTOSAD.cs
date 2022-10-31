using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01VENTAGASTOSAD
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_FOLIO { get; set; }
        public short? U_SO1_NUMPARTIDA { get; set; }
        public short? U_SO1_LINEAGASTO { get; set; }
        public int? U_SO1_CODIGOGASTO { get; set; }
        public decimal? U_SO1_IMPORTE { get; set; }
        public decimal? U_SO1_IMPUESTO { get; set; }
        public decimal? U_SO1_IMPORTEFACTURA { get; set; }
        public decimal? U_SO1_IMPUESTFACTURA { get; set; }
    }
}

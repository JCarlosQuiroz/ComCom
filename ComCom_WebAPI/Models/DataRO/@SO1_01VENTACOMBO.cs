using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01VENTACOMBO
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string U_SO1_FOLIO { get; set; } = null!;
        public short U_SO1_LINEA { get; set; }
        public string U_SO1_CODIGOCOMBO { get; set; } = null!;
        public decimal U_SO1_CANTIDAD { get; set; }
        public decimal U_SO1_PRECIO { get; set; }
        public string U_SO1_TIPOCANTIDAD { get; set; } = null!;
    }
}

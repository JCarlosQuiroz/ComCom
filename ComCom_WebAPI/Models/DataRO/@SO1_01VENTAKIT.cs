using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01VENTAKIT
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string U_SO1_FOLIO { get; set; } = null!;
        public string U_SO1_CODIGOKIT { get; set; } = null!;
        public int U_SO1_LINEA { get; set; }
    }
}

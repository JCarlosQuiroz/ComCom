using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01VENTAPAGOSERV
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_COMPANIA { get; set; }
        public string? U_SO1_REFERENCIA { get; set; }
        public string? U_SO1_DIGITOVERIFICA { get; set; }
        public decimal? U_SO1_IMPORTE { get; set; }
        public string? U_SO1_AUTORIZACION { get; set; }
        public string? U_SO1_LEYENDA { get; set; }
    }
}

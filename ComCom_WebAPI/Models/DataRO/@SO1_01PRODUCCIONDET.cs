using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01PRODUCCIONDET
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? U_SO1_FOLIO { get; set; }
        public short? U_SO1_NUMPARTIDA { get; set; }
        public string? U_SO1_NUMEROARTICULO { get; set; }
        public decimal? U_SO1_CANTIDADBASE { get; set; }
        public decimal? U_SO1_CANTIDADREQUE { get; set; }
        public string? U_SO1_ALMACEN { get; set; }
        public string U_SO1_METODOEMISION { get; set; } = null!;
    }
}

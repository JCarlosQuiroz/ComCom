using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01VENTADETRETE
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string U_SO1_FOLIO { get; set; } = null!;
        public short? U_SO1_NUMPARTIDA { get; set; }
        public decimal? U_SO1_BASE { get; set; }
        public string? U_SO1_TIPORETENCION { get; set; }
        public string? U_SO1_TIPOFACTOR { get; set; }
        public decimal? U_SO1_TASACUOTA { get; set; }
        public decimal? U_SO1_IMPORTERETE { get; set; }
        public string? U_SO1_CODIGORETE { get; set; }
        public short? U_SO1_LINEARETENCION { get; set; }
    }
}

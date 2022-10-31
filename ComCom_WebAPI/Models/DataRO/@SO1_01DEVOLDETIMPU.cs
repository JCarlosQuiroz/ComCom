using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01DEVOLDETIMPU
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string U_SO1_FOLIO { get; set; } = null!;
        public short? U_SO1_LINEAIMPUESTO { get; set; }
        public short? U_SO1_NUMPARTIDA { get; set; }
        public decimal? U_SO1_BASE { get; set; }
        public string? U_SO1_TIPOIMPUESTO { get; set; }
        public string? U_SO1_TIPOFACTOR { get; set; }
        public decimal? U_SO1_TASACUOTA { get; set; }
        public decimal? U_SO1_IMPORTEIMPU { get; set; }
        public string? U_SO1_CODIGOIMPU { get; set; }
    }
}

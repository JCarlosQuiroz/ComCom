using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01ACTPRECIOSART
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_FOLIO { get; set; }
        public short? U_SO1_NUMPARTIDA { get; set; }
        public string? U_SO1_NUMEROARTICULO { get; set; }
        public string? U_SO1_MONEDA { get; set; }
        public decimal? U_SO1_PRECIO { get; set; }
        public string? U_SO1_INDICADORIMP { get; set; }
        public decimal? U_SO1_TASAIMPUESTO { get; set; }
        public decimal? U_SO1_PRECIOSINIMP { get; set; }
    }
}

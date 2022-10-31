using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01SUGERENCOMDET
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_FOLIO { get; set; }
        public string? U_SO1_NUMEROARTICULO { get; set; }
        public short? U_SO1_NUMPARTIDA { get; set; }
        public decimal? U_SO1_EXISTENCIA { get; set; }
        public decimal? U_SO1_PROMVENTAS { get; set; }
        public decimal? U_SO1_PROMCOMPRAS { get; set; }
        public decimal? U_SO1_SOLICITADOCOMP { get; set; }
        public decimal? U_SO1_SOLICITADOTRAS { get; set; }
        public short? U_SO1_DIASRESURTIDO { get; set; }
        public decimal? U_SO1_SUGERIDO { get; set; }
        public decimal? U_SO1_AJUSTADO { get; set; }
        public short? U_SO1_INSTANCIA { get; set; }
        public decimal? U_SO1_CANTIDADAB { get; set; }
        public decimal? U_SO1_PIEZASVENDIDAS { get; set; }
        public int? U_SO1_DIASENTREGAPRO { get; set; }
        public int? U_SO1_TOTALDIAS { get; set; }
        public decimal? U_SO1_PRECIO { get; set; }
        public decimal? U_SO1_COSTO { get; set; }
        public DateTime? U_SO1_ULTIMACOMPRA { get; set; }
        public DateTime? U_SO1_ULTIMAVENTA { get; set; }
    }
}

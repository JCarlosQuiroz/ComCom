using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01SERIEALTERNA
    {
        public string Code { get; set; } = null!;
        public int LineId { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public short? U_SO1_SERIE { get; set; }
        public string? U_SO1_PREFIJO { get; set; }
        public int? U_SO1_FOLIO { get; set; }
        public string? U_SO1_RPTCONTADO { get; set; }
        public string? U_SO1_RPTCREDITO { get; set; }
        public string U_SO1_ACTIVO { get; set; } = null!;
        public string? U_SO1_SERIEDESCRIP { get; set; }
        public int? U_SO1_FOLIOFINAL { get; set; }
        public int? U_SO1_FOLIOINICIO { get; set; }
        public string? U_SO1_RESOLUCION { get; set; }
        public DateTime? U_SO1_FECHARESOLU { get; set; }
        public DateTime? U_SO1_FECHAAUTORIZA { get; set; }
        public short? U_SO1_FOLIOSALARMA { get; set; }
        public short? U_SO1_ORDEN { get; set; }
        public string U_SO1_ESFOLIOUNICO { get; set; } = null!;
        public string? U_SO1_NOMBREIMP { get; set; }
    }
}

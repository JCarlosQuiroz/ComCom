using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01ETAPAOPVENTum
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_VENDEDOR { get; set; }
        public DateTime? U_SO1_FECHACIERRE { get; set; }
        public string? U_SO1_ETAPA { get; set; }
        public decimal U_SO1_PORCENTAJE { get; set; }
        public string? U_SO1_FOLIO { get; set; }
        public string? U_SO1_LINEAETAPA { get; set; }
        public string? U_SO1_FOLIODOCUMENTO { get; set; }
    }
}

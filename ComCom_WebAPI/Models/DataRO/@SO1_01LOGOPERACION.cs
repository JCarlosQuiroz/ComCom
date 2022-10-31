using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01LOGOPERACION
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_FOLIO { get; set; }
        public string? U_SO1_TIPOOPER { get; set; }
        public string? U_SO1_ARCHIVONOM { get; set; }
        public DateTime? U_SO1_FECHAPROC { get; set; }
        public short? U_SO1_HORAPROC { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01LOGAUTORIZA
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string U_SO1_TIPO { get; set; } = null!;
        public string? U_SO1_IDENTIFICADOR { get; set; }
        public short? U_SO1_INSTANCIA { get; set; }
        public string? U_SO1_USUARIO { get; set; }
        public DateTime? U_SO1_FECHAACCESO { get; set; }
        public short? U_SO1_HORAACCESO { get; set; }
        public DateTime? U_SO1_FECHASALIDA { get; set; }
        public short? U_SO1_HORASALIDA { get; set; }
        public string? U_SO1_USUARIOAUTO { get; set; }
        public string? U_SO1_FOLIO { get; set; }
    }
}

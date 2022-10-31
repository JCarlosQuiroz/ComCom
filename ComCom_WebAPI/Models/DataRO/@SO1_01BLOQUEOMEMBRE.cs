using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01BLOQUEOMEMBRE
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? U_SO1_MEMBRESIA { get; set; }
        public DateTime? U_SO1_FECHABLOQUEO { get; set; }
        public short? U_SO1_HORABLOQUEO { get; set; }
        public string? U_SO1_SUCURSALBLOQUE { get; set; }
        public DateTime? U_SO1_FECHADESBLOQUE { get; set; }
        public short? U_SO1_HORADESBLOQUEO { get; set; }
        public int? U_SO1_USUARIODESBLOQ { get; set; }
        public string? U_SO1_SUCURSALDESBLO { get; set; }
    }
}

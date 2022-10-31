using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01PUBLICIDAD
    {
        public string Code { get; set; } = null!;
        public int LineId { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public string? U_SO1_RECURSO { get; set; }
        public string? U_SO1_DURACION { get; set; }
        public string? U_SO1_RUTAORIGEN { get; set; }
        public short U_SO1_DESTINO { get; set; }
        public string? U_SO1_MENSAJE { get; set; }
        public DateTime? U_SO1_ACTIVARDESDE { get; set; }
        public DateTime? U_SO1_ACTIVARHASTA { get; set; }
    }
}

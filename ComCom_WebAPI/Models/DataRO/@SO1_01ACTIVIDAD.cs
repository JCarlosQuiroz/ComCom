using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01ACTIVIDAD
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_LINEAOPORTUNV { get; set; }
        public string? U_SO1_ACTIVIDAD { get; set; }
        public string? U_SO1_TIPOACTIVIDAD { get; set; }
        public string? U_SO1_CONTACTO { get; set; }
        public string? U_SO1_ASUNTO { get; set; }
        public string? U_SO1_TELEFONO { get; set; }
        public string? U_SO1_PRIORIDAD { get; set; }
        public string? U_SO1_COMENTARIOS { get; set; }
        public DateTime? U_SO1_FECHA { get; set; }
        public short? U_SO1_HORA { get; set; }
        public string? U_SO1_RECORDATORIO { get; set; }
        public string? U_SO1_MINRECORDATOR { get; set; }
        public string? U_SO1_FOLIO { get; set; }
        public string? U_SO1_LINEAETAPA { get; set; }
    }
}

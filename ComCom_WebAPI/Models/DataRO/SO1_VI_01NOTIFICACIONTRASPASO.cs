using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class SO1_VI_01NOTIFICACIONTRASPASO
    {
        public string? Folio { get; set; }
        public string? Fecha { get; set; }
        public string? Hora { get; set; }
        public string? Estacion { get; set; }
        public string Tipo { get; set; } = null!;
    }
}

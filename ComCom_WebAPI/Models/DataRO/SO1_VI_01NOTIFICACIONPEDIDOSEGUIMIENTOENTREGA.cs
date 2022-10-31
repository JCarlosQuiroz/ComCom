using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class SO1_VI_01NOTIFICACIONPEDIDOSEGUIMIENTOENTREGA
    {
        public string Folio { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public string? Hora { get; set; }
        public int? HoraOrden { get; set; }
        public string Tipo { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class corte2
    {
        public uint? ID_CLIENTE { get; set; }
        public string? NOMBRE { get; set; }
        public uint? _VALE { get; set; }
        public DateOnly? FECHA_COMPRA { get; set; }
        public string SUCURSAL { get; set; } = null!;
        public uint fortnights { get; set; }
        public uint number { get; set; }
        public string ultimo_pago { get; set; } = null!;
    }
}

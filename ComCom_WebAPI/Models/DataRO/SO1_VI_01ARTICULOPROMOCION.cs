using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class SO1_VI_01ARTICULOPROMOCION
    {
        public string? Articulo { get; set; }
        public string CodigoPromocion { get; set; } = null!;
        public string Tipo { get; set; } = null!;
    }
}

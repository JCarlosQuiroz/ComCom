using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CATPAGOSERVI
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_SKU { get; set; }
        public string? U_SO1_BENEFICIARIO { get; set; }
        public string? U_SO1_DESCRIPCION { get; set; }
        public string U_SO1_DIGITOVERIFICA { get; set; } = null!;
        public string? U_SO1_ARTICULOCOMI { get; set; }
        public decimal? U_SO1_IMPORTECOMI { get; set; }
    }
}

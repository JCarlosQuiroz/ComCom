using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CATCOLONIA
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_NOMBRE { get; set; }
        public string? U_SO1_REGION { get; set; }
        public string? U_SO1_ZONA { get; set; }
        public string U_SO1_FORANEA { get; set; } = null!;
    }
}

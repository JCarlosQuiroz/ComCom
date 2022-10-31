using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CATOPERACION
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CODMODULO { get; set; }
        public string? U_SO1_LENGDESCOPERA { get; set; }
    }
}

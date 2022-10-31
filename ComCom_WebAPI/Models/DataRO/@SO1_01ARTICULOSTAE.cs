using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01ARTICULOSTAE
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_ARTICULOTAE { get; set; }
        public string? U_SO1_COMPANIATAE { get; set; }
    }
}

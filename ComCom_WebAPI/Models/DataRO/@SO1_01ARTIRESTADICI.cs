using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01ARTIRESTADICI
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string U_SO1_TIPOPADRE { get; set; } = null!;
        public string? U_SO1_PADRE { get; set; }
        public string U_SO1_TIPOADICIONAL { get; set; } = null!;
        public string? U_SO1_VALORADICIONAL { get; set; }
        public string? U_SO1_DESCRIPCION { get; set; }
        public int? U_SO1_UMI { get; set; }
        public string U_SO1_INFOBLIGA { get; set; } = null!;
    }
}

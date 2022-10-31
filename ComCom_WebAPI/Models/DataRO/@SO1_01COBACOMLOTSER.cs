using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01COBACOMLOTSER
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string U_SO1_TIPOCODIGO { get; set; } = null!;
        public string? U_SO1_POSICION { get; set; }
        public string U_SO1_CATEGORIA { get; set; } = null!;
    }
}

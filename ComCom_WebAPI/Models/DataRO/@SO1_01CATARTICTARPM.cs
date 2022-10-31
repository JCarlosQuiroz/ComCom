using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CATARTICTARPM
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string U_SO1_TIPOSERVIWEB { get; set; } = null!;
        public string? U_SO1_IDCATEGORIA { get; set; }
        public string? U_SO1_NOMBRECATEGOR { get; set; }
        public string U_SO1_TIPOCATEGORIA { get; set; } = null!;
        public string U_SO1_ACTIVO { get; set; } = null!;
    }
}

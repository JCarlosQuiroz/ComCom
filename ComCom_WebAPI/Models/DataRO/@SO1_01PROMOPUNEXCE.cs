using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01PROMOPUNEXCE
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CODIGOPROMO { get; set; }
        public string U_SO1_TIPOEXCEPCION { get; set; } = null!;
        public string? U_SO1_CODIGOEXCEP { get; set; }
    }
}

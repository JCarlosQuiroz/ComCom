using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01PROMOPUNLIPR
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CODIGOPROMO { get; set; }
        public short? U_SO1_LISTAPRECIOS { get; set; }
        public string U_SO1_ACTIVA { get; set; } = null!;
    }
}

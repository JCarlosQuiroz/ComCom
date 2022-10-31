using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01DEPTOESPEDET
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_SUCURSAL { get; set; }
        public string U_SO1_TIPO { get; set; } = null!;
        public string? U_SO1_CODIGOBARRAS { get; set; }
        public string? U_SO1_DEPTOEXTRA { get; set; }
        public string U_SO1_ACTIVO { get; set; } = null!;
        public short? U_SO1_SUMADEPTO { get; set; }
        public short? U_SO1_RESTADEPTO { get; set; }
    }
}

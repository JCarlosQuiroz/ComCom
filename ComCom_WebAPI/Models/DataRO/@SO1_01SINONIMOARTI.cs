using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01SINONIMOARTI
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_ARTICULO { get; set; }
        public int? U_SO1_NUMEROLINEA { get; set; }
        public string? U_SO1_CODIGOSINONIMO { get; set; }
        public string? U_SO1_DESCRIPCION { get; set; }
        public decimal? U_SO1_CANTIDAD { get; set; }
        public int? U_SO1_UNIDAD { get; set; }
        public decimal? U_SO1_FACTOR { get; set; }
        public string U_SO1_ACTIVO { get; set; } = null!;
        public string? U_SO1_UMI { get; set; }
    }
}

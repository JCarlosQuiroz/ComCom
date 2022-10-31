using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CUPONSORTEO
    {
        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public short? U_SO1_CODIGPROMOCION { get; set; }
        public string? U_SO1_PROMOCADENA { get; set; }
        public short? U_SO1_TIPO { get; set; }
        public decimal? U_SO1_MONTO { get; set; }
        public decimal? U_SO1_CANTIDAD { get; set; }
        public short? U_SO1_NUMEROCUPONES { get; set; }
        public string? U_SO1_ACTIMPORTEIMP { get; set; }
        public short? U_SO1_COMPOTRASPROM { get; set; }
        public string? U_SO1_APLICPROMIGUAL { get; set; }
        public short? U_SO1_TIPOCOMPORTAMI { get; set; }
    }
}

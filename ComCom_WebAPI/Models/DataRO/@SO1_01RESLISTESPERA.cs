using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01RESLISTESPERA
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? U_SO1_CODIGOCLIENTE { get; set; }
        public string? U_SO1_NOMBRECLIENTE { get; set; }
        public short? U_SO1_NUMCOMENSAL { get; set; }
        public string? U_SO1_OBSERVACION { get; set; }
        public string? U_SO1_COMENTARIO { get; set; }
        public string? U_SO1_SUCURSAL { get; set; }
        public string? U_SO1_ESTACION { get; set; }
        public int? U_SO1_USUARIO { get; set; }
        public DateTime? U_SO1_FECHA { get; set; }
        public DateTime? U_SO1_FECHAFIN { get; set; }
        public int? U_SO1_HORAINICIO { get; set; }
        public int? U_SO1_HORAFIN { get; set; }
        public string? U_SO1_HORAINICADENA { get; set; }
        public string? U_SO1_HORAFINCADENA { get; set; }
        public int? U_SO1_CODCONTACTO { get; set; }
        public int? U_SO1_TIEMPOESPERA { get; set; }
        public string U_SO1_STATUS { get; set; } = null!;
        public string U_SO1_TIPO { get; set; } = null!;
        public string U_SO1_CLIENTEALTERNO { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CLIEALTERNO
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? U_SO1_CODIGOCLIENTE { get; set; }
        public string? U_SO1_RFC { get; set; }
        public string? U_SO1_RAZONSOCIAL { get; set; }
        public string? U_SO1_TELEFONO { get; set; }
        public string? U_SO1_CORREO { get; set; }
        public string? U_SO1_SUCURSAL { get; set; }
        public DateTime? U_SO1_VIGENCIADESDE { get; set; }
        public DateTime? U_SO1_VIGENCIAHASTA { get; set; }
        public string U_SO1_TIPOCLIENTEALT { get; set; } = null!;
        public string U_SO1_TIPO { get; set; } = null!;
        public string? U_SO1_GRUPOCLIENTE { get; set; }
        public string? U_SO1_TIPOSOCIO { get; set; }
        public string? U_SO1_VENDEDOR { get; set; }
        public string? U_SO1_LISTAPRECIO { get; set; }
        public string? U_SO1_CONDICIONPAGO { get; set; }
        public string? U_SO1_METODOENVIO { get; set; }
        public string? U_SO1_NUMEROCUENTA { get; set; }
        public string? U_SO1_COMENTARIOS { get; set; }
        public string U_SO1_ACTIVO { get; set; } = null!;
        public string? U_SO1_METODOPAGO { get; set; }
        public string? U_SO1_CFDIUSOCFDI { get; set; }
    }
}

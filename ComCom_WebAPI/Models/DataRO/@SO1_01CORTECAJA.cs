using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CORTECAJA
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_SUCURSAL { get; set; }
        public string? U_SO1_ESTACION { get; set; }
        public int? U_SO1_USUARIO { get; set; }
        public string U_SO1_TIPO { get; set; } = null!;
        public DateTime? U_SO1_FECHAINICIO { get; set; }
        public short? U_SO1_HORAINICIO { get; set; }
        public string? U_SO1_HORACADENAINI { get; set; }
        public DateTime? U_SO1_FECHAFIN { get; set; }
        public short? U_SO1_HORAFIN { get; set; }
        public string? U_SO1_HORACADENAFIN { get; set; }
        public string? U_SO1_FOLIOCIERREZ { get; set; }
        public int? U_SO1_USUARIOCORTE { get; set; }
        public string? U_SO1_ESTACIONCREADA { get; set; }
        public string? U_SO1_CORTEXAUTO { get; set; }
        public string? U_SO1_VERSIONR1 { get; set; }
    }
}

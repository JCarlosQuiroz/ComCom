using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01SUCURSALALMA
    {
        public string Code { get; set; } = null!;
        public int LineId { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public string? U_SO1_CODIGOALMACEN { get; set; }
        public string? U_SO1_NOMBREALMACEN { get; set; }
        public string? U_SO1_ACTIVO { get; set; }
        public string U_SO1_REPLICAREXISTE { get; set; } = null!;
        public string? U_SO1_NOMBRIMPRESORA { get; set; }
        public string U_SO1_BLOQUEARVENTA { get; set; } = null!;
        public string U_SO1_TRASPASOAUTOMA { get; set; } = null!;
        public string U_SO1_RESERVADO { get; set; } = null!;
        public string U_SO1_SALIDAEXT { get; set; } = null!;
        public string? U_SO1_TIPOENTREGA { get; set; }
    }
}

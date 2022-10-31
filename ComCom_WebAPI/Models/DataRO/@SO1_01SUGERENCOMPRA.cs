using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01SUGERENCOMPRA
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? U_SO1_FECHA { get; set; }
        public short? U_SO1_HORA { get; set; }
        public string? U_SO1_HORACADENA { get; set; }
        public string? U_SO1_SUCURSAL { get; set; }
        public string? U_SO1_ESTACION { get; set; }
        public int? U_SO1_USUARIO { get; set; }
        public string? U_SO1_PROVEEDOR { get; set; }
        public string U_SO1_STATUS { get; set; } = null!;
        public short? U_SO1_INSTANCIA { get; set; }
        public string U_SO1_CORREOENVIADO { get; set; } = null!;
        public string? U_SO1_FOLIO { get; set; }
        public DateTime? U_SO1_FECHAINICIAL { get; set; }
        public DateTime? U_SO1_FECHAFINAL { get; set; }
        public short? U_SO1_DIASRESURTIDO { get; set; }
        public DateTime? U_SO1_FECHAAUTORIZA { get; set; }
        public string? U_SO1_USUARIOAUTORI { get; set; }
        public string? U_SO1_INTERCOMPANIA { get; set; }
        public string? U_SO1_FOLIODESTINO { get; set; }
        public string? U_SO1_VERSIONR1 { get; set; }
    }
}

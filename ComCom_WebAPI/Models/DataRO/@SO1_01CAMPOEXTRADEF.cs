using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CAMPOEXTRADEF
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string U_SO1_NOMBRE { get; set; } = null!;
        public string U_SO1_PADRENIVEL2 { get; set; } = null!;
        public string U_SO1_DESCRIPCION { get; set; } = null!;
        public string U_SO1_TIPO { get; set; } = null!;
        public string U_SO1_SUBTIPO { get; set; } = null!;
        public short? U_SO1_LONGITUD { get; set; }
        public short? U_SO1_DECIMALES { get; set; }
        public string? U_SO1_MAPEOSBO { get; set; }
        public string U_SO1_OBLIGATORIO { get; set; } = null!;
        public string U_SO1_ACTIVO { get; set; } = null!;
        public string U_SO1_VALORESVALIDOS { get; set; } = null!;
        public string? U_SO1_VALORDEFECTO { get; set; }
        public short? U_SO1_ORDEN { get; set; }
        public string U_SO1_TIPOCONTROL { get; set; } = null!;
        public string? U_SO1_CATALOARTICULO { get; set; }
    }
}

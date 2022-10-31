using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01MODULOMENU
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_MODULO { get; set; }
        public string? U_SO1_CONTROLUSUARIO { get; set; }
        public string? U_SO1_OPCIONMENU { get; set; }
        public string? U_SO1_DESCRIPCION { get; set; }
        public string? U_SO1_LENGUAJE { get; set; }
        public string? U_SO1_LENGUAJEALT { get; set; }
        public string U_SO1_TECLADEFECTO { get; set; } = null!;
        public string? U_SO1_IMAGEN { get; set; }
    }
}

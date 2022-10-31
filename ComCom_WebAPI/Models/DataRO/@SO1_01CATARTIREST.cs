using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CATARTIREST
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CODIGO { get; set; }
        public string? U_SO1_DESCRIPCION { get; set; }
        public short? U_SO1_NIVEL { get; set; }
        public string? U_SO1_PADRE { get; set; }
        public string? U_SO1_COLOR { get; set; }
        public short? U_SO1_PRIORIDAD { get; set; }
        public string? U_SO1_CATALOGOMENU { get; set; }
        public string? U_SO1_CODHORARIO { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01ACCIONRESTum
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_DESCRIPCION { get; set; }
        public string? U_SO1_LENGUAJE { get; set; }
        public string? U_SO1_IMAGEN { get; set; }
        public string? U_SO1_CAMBIOAESTADO { get; set; }
        public string? U_SO1_DESCR_EN { get; set; }
    }
}

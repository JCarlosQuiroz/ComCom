using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01OPORTUNIVENTum
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CONTACTO { get; set; }
        public DateTime? U_SO1_FECHACIERREPRE { get; set; }
        public string? U_SO1_NOMBREOPORTUNI { get; set; }
        public string? U_SO1_COMENTARIOS { get; set; }
        public string? U_SO1_ANEXO { get; set; }
        public string? U_SO1_FOLIO { get; set; }
        public string U_SO1_SINCRONIZADO { get; set; } = null!;
    }
}

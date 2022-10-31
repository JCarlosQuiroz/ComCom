﻿using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CANCECOBDET
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_FOLIO { get; set; }
        public short? U_SO1_NUMPARTIDA { get; set; }
        public string? U_SO1_FOLIOOPERACION { get; set; }
        public int? U_SO1_DOCUMENTOSBO { get; set; }
        public decimal? U_SO1_MONTOPAGADO { get; set; }
        public int? U_SO1_NUMDOCUMENTO { get; set; }
        public short? U_SO1_NUMEROPLAZO { get; set; }
        public short? U_SO1_TOTALPLAZOS { get; set; }
        public string U_SO1_TIPODOC { get; set; } = null!;
        public string? U_SO1_FOLIOFISCAL { get; set; }
        public string? U_SO1_COMENTARIOS { get; set; }
        public decimal? U_SO1_PORCENTAJEDESC { get; set; }
        public decimal? U_SO1_IMPORTEDESCUEN { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01NUMEROSSERIE
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? U_SO1_TIPO { get; set; }
        public string? U_SO1_FOLIO { get; set; }
        public short? U_SO1_INSTANCIA { get; set; }
        public int? U_SO1_NUMEROPARTIDA { get; set; }
        public string? U_SO1_NUMEROARTICULO { get; set; }
        public int? U_SO1_NUMEROLINEA { get; set; }
        public int? U_SO1_NUMEROSISTEMA { get; set; }
        public string? U_SO1_IDENTIFICADOR { get; set; }
        public int? U_SO1_PARTIDABASE { get; set; }
        public string U_SO1_ESTADO { get; set; } = null!;
        public string? U_SO1_ESTADOFAC { get; set; }
    }
}

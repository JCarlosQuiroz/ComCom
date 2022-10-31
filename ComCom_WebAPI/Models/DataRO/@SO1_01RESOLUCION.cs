using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01RESOLUCION
    {
        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public int DocEntry { get; set; }
        public string? Canceled { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public int? UserSign { get; set; }
        public string? Transfered { get; set; }
        public DateTime? CreateDate { get; set; }
        public short? CreateTime { get; set; }
        public DateTime? UpdateDate { get; set; }
        public short? UpdateTime { get; set; }
        public string? DataSource { get; set; }
        public string? U_SO1_NOMBRE { get; set; }
        public DateTime? U_SO1_FECHAUTO { get; set; }
        public DateTime? U_SO1_FECHAINI { get; set; }
        public short? U_SO1_SERIERESO { get; set; }
        public string? U_SO1_FOLIOINI { get; set; }
        public string? U_SO1_FOLIOFIN { get; set; }
        public string? U_SO1_RANGOFAC { get; set; }
        public string? U_SO1_FOLIOSIG { get; set; }
        public string? U_SO1_PREFIJO { get; set; }
        public string U_SO1_TIOPORESO { get; set; } = null!;
        public string U_SO1_REACTIVA { get; set; } = null!;
        public short U_SO1_CNTDALARMA { get; set; }
        public string U_SO1_TIPOVENCIMIEN { get; set; } = null!;
        public DateTime U_SO1_FECHAVENCIMIEN { get; set; }
        public string? U_SO1_LEYENDA { get; set; }
        public string? U_SO1_RUBRO { get; set; }
        public string? U_SO1_LLAVE { get; set; }
        public string U_SO1_SINCFOLIOSIG { get; set; } = null!;
        public string U_SO1_DOSIMANUAL { get; set; } = null!;
        public string? U_SO1_NUMCAI { get; set; }
        public string? U_SO1_NUMRANGOFISCAL { get; set; }
        public string? U_SO1_PREFCORREFISCA { get; set; }
        public string? U_SO1_CODSATPREFGUAT { get; set; }
    }
}

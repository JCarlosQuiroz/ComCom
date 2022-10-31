using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01TARJETAPUNTO
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
        public decimal? U_SO1_MONTOMINACTIVA { get; set; }
        public int? U_SO1_PUNTOMINREDENC { get; set; }
        public int? U_SO1_PUNTOBLOQREDEN { get; set; }
        public decimal? U_SO1_TASAREDENCION { get; set; }
        public decimal? U_SO1_MONTOMINFORPA { get; set; }
        public string? U_SO1_ARTITARPUNTOS { get; set; }
        public string? U_SO1_NARTITAPUNTOS { get; set; }
        public int U_SO1_PUNTOACUACTIV { get; set; }
        public int U_SO1_PUNTOSINIMEM { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01PARAMETROVP1
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
        public string? U_SO1_DESCRIPCION { get; set; }
    }
}

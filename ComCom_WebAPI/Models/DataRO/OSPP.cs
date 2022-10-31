using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OSPP
    {
        public string ItemCode { get; set; } = null!;
        public string CardCode { get; set; } = null!;
        public decimal? Price { get; set; }
        public string? Currency { get; set; }
        public decimal? Discount { get; set; }
        public short? ListNum { get; set; }
        public string? AutoUpdt { get; set; }
        public string? EXPAND { get; set; }
        public short? UserSign { get; set; }
        public short? SrcPrice { get; set; }
        public int? LogInstanc { get; set; }
        public short? UserSign2 { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}

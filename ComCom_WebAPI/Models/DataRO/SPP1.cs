using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class SPP1
    {
        public string ItemCode { get; set; } = null!;
        public string CardCode { get; set; } = null!;
        public short LINENUM { get; set; }
        public decimal? Price { get; set; }
        public string? Currency { get; set; }
        public decimal? Discount { get; set; }
        public short? ListNum { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? AutoUpdt { get; set; }
        public string? Expand { get; set; }
        public int? LogInstanc { get; set; }
    }
}

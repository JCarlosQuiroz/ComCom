using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class ITM9
    {
        public string ItemCode { get; set; } = null!;
        public short PriceList { get; set; }
        public int UomEntry { get; set; }
        public decimal? Factor { get; set; }
        public decimal? Price { get; set; }
        public string? Currency { get; set; }
        public string? AutoUpdate { get; set; }
        public decimal? AddPrice1 { get; set; }
        public string? Currency1 { get; set; }
        public decimal? AddPrice2 { get; set; }
        public string? Currency2 { get; set; }
        public int? LogInstanc { get; set; }
        public string? ObjType { get; set; }
        public decimal? Factor1 { get; set; }
        public decimal? Factor2 { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}

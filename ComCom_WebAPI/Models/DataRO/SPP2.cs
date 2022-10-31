using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class SPP2
    {
        public string ItemCode { get; set; } = null!;
        public string CardCode { get; set; } = null!;
        public short SPP1LNum { get; set; }
        public short SPP2LNum { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Price { get; set; }
        public string? Currency { get; set; }
        public decimal? Discount { get; set; }
        public short? UomEntry { get; set; }
        public int? LogInstanc { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OIBQ
    {
        public int? AbsEntry { get; set; }
        public string ItemCode { get; set; } = null!;
        public int BinAbs { get; set; }
        public decimal? OnHandQty { get; set; }
        public string? WhsCode { get; set; }
        public string? Freezed { get; set; }
        public int? FreezeDoc { get; set; }
    }
}

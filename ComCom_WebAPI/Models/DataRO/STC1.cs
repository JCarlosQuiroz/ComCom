using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class STC1
    {
        public string STCCode { get; set; } = null!;
        public int Line_ID { get; set; }
        public string? STACode { get; set; }
        public int? STAType { get; set; }
        public string? TaxOnTCode { get; set; }
        public int? TaxOnTType { get; set; }
        public decimal? EfctivRate { get; set; }
        public int? FmlId { get; set; }
        public string? CstCodeIn { get; set; }
        public string? CstSuffix { get; set; }
        public int? LogInstanc { get; set; }
    }
}

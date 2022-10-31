using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OSTC
    {
        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public decimal? Rate { get; set; }
        public string? Freight { get; set; }
        public short? UserSign { get; set; }
        public string? ValidForAR { get; set; }
        public string? ValidForAP { get; set; }
        public int? TfcId { get; set; }
        public string? Lock { get; set; }
        public string? TaxIcms { get; set; }
        public string? IsItmLevel { get; set; }
        public string? CfopIn { get; set; }
        public string? CfopOut { get; set; }
        public int? LogInstanc { get; set; }
        public short? UserSign2 { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? FADebit { get; set; }
        public string? IsSystem { get; set; }
        public string U_B1SYS_FactorType { get; set; } = null!;
    }
}

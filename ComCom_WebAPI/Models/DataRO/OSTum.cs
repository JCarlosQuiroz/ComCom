using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OSTum
    {
        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public decimal? Rate { get; set; }
        public string? SalesTax { get; set; }
        public string? UseTax { get; set; }
        public int Type { get; set; }
        public short? UserSign { get; set; }
        public string? PurchTax { get; set; }
        public string? deferrAcct { get; set; }
        public decimal? NonDdctPrc { get; set; }
        public string? NonDdctAct { get; set; }
        public string? TaxInPrice { get; set; }
        public string? Exempt { get; set; }
        public string? APExpAct { get; set; }
        public string? ARExpAct { get; set; }
        public decimal? CredBala { get; set; }
        public decimal? CredFG { get; set; }
        public decimal? CredCG { get; set; }
        public string? InGrossRev { get; set; }
        public DateTime? EfctDate { get; set; }
        public decimal? SvcTaxCr { get; set; }
        public decimal? MinAmount { get; set; }
        public decimal? MaxAmount { get; set; }
        public decimal? FlatAmount { get; set; }
        public short? TextCode { get; set; }
        public string? UnencumTax { get; set; }
        public string? TaxOnRI { get; set; }
        public string? DIOTRptTyp { get; set; }
        public string? IsSystem { get; set; }
        public decimal? RvsCrgPrc { get; set; }
    }
}

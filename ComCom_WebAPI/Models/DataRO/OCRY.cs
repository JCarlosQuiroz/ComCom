using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OCRY
    {
        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public short? AddrFormat { get; set; }
        public short? UserSign { get; set; }
        public string? IsEC { get; set; }
        public string? ReportCode { get; set; }
        public short? TaxIdDigts { get; set; }
        public int? BnkCodDgts { get; set; }
        public int? BnkBchDgts { get; set; }
        public int? BnkActDgts { get; set; }
        public int? BnkCtKDgts { get; set; }
        public string? ValDomAcct { get; set; }
        public string? ValIban { get; set; }
        public string? IsBlackLst { get; set; }
        public string? UICCode { get; set; }
        public string? CntCodNum { get; set; }
        public string? Siscomex { get; set; }
        public string? IsIntraS { get; set; }
        public string? EAEU { get; set; }
    }
}

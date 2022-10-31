using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class CRD1
    {
        public string Address { get; set; } = null!;
        public string CardCode { get; set; } = null!;
        public string? Street { get; set; }
        public string? Block { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public string? County { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public short? UserSign { get; set; }
        public int? LogInstanc { get; set; }
        public string? ObjType { get; set; }
        public string? LicTradNum { get; set; }
        public int? LineNum { get; set; }
        public string? TaxCode { get; set; }
        public string? Building { get; set; }
        public string AdresType { get; set; } = null!;
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? AddrType { get; set; }
        public string? StreetNo { get; set; }
        public string? AltCrdName { get; set; }
        public string? AltTaxId { get; set; }
        public string? TaxOffice { get; set; }
        public string? GlblLocNum { get; set; }
        public string? Ntnlty { get; set; }
        public string? DIOTNat { get; set; }
        public string? GSTRegnNo { get; set; }
        public int? GSTType { get; set; }
        public string? TaaSEnbl { get; set; }
        public string? U_SO1_01CATZONA { get; set; }
    }
}

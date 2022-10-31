using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OCDC
    {
        public string Code { get; set; } = null!;
        public string? TableDesc { get; set; }
        public string? ByDate { get; set; }
        public string? Freight { get; set; }
        public string? Tax { get; set; }
        public string? VatCrctn { get; set; }
        public string? BaseDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class ITM2
    {
        public string ItemCode { get; set; } = null!;
        public string VendorCode { get; set; } = null!;
        public int? LogInstanc { get; set; }
        public string? ObjType { get; set; }
    }
}

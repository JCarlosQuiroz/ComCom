using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OSPG
    {
        public string CardCode { get; set; } = null!;
        public string ObjType { get; set; } = null!;
        public string ObjKey { get; set; } = null!;
        public decimal? Discount { get; set; }
        public string? DataSource { get; set; }
        public short? UserSign { get; set; }
    }
}

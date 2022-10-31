using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OCRG
    {
        public short GroupCode { get; set; }
        public string GroupName { get; set; } = null!;
        public string? GroupType { get; set; }
        public string? Locked { get; set; }
        public string? DataSource { get; set; }
        public short? UserSign { get; set; }
        public short? PriceList { get; set; }
        public string? DiscRel { get; set; }
    }
}

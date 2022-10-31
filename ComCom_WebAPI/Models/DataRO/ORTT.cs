using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class ORTT
    {
        public DateTime RateDate { get; set; }
        public string Currency { get; set; } = null!;
        public decimal? Rate { get; set; }
        public string? DataSource { get; set; }
        public short? UserSign { get; set; }
    }
}

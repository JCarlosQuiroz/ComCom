using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OBCD
    {
        public int BcdEntry { get; set; }
        public string BcdCode { get; set; } = null!;
        public string? BcdName { get; set; }
        public string ItemCode { get; set; } = null!;
        public int UomEntry { get; set; }
        public string? DataSource { get; set; }
        public short? UserSign { get; set; }
        public int? LogInstanc { get; set; }
        public short? UserSign2 { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OSCN
    {
        public string ItemCode { get; set; } = null!;
        public string CardCode { get; set; } = null!;
        public string Substitute { get; set; } = null!;
        public string? Transfered { get; set; }
        public string? DataSource { get; set; }
        public short? UserSign { get; set; }
        public short? UserSign2 { get; set; }
        public string? ShowSCN { get; set; }
    }
}

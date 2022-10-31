using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class OSHP
    {
        public short TrnspCode { get; set; }
        public string? TrnspName { get; set; }
        public string? DataSource { get; set; }
        public short? UserSign { get; set; }
        public string? WebSite { get; set; }
        public string U_SO1_01USARIMPCLIE { get; set; } = null!;
        public string U_SO1_01PRIORIDAD { get; set; } = null!;
        public string U_SO1_01ENTRETIENDA { get; set; } = null!;
    }
}

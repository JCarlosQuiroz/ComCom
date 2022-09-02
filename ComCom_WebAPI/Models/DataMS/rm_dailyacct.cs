using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_dailyacct
    {
        public long radacctid { get; set; }
        public string acctuniqueid { get; set; } = null!;
        public string username { get; set; } = null!;
        public DateTime acctstarttime { get; set; }
        public DateTime acctstoptime { get; set; }
        public int acctsessiontime { get; set; }
        public long dlbytesstart { get; set; }
        public long dlbytesstop { get; set; }
        public long dlbytes { get; set; }
        public long ulbytesstart { get; set; }
        public long ulbytesstop { get; set; }
        public long ulbytes { get; set; }
    }
}

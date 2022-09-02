using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_syslog
    {
        public int id { get; set; }
        public DateTime datetime { get; set; }
        public string ip { get; set; } = null!;
        public string name { get; set; } = null!;
        public int eventid { get; set; }
        public string data1 { get; set; } = null!;
    }
}

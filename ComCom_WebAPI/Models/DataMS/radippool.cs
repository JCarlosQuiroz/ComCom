using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class radippool
    {
        public uint id { get; set; }
        public string pool_name { get; set; } = null!;
        public string framedipaddress { get; set; } = null!;
        public string nasipaddress { get; set; } = null!;
        public string calledstationid { get; set; } = null!;
        public string callingstationid { get; set; } = null!;
        public DateTime? expiry_time { get; set; }
        public string username { get; set; } = null!;
        public string pool_key { get; set; } = null!;
    }
}

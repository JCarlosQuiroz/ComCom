using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class radacct
    {
        public long radacctid { get; set; }
        public string acctsessionid { get; set; } = null!;
        public string acctuniqueid { get; set; } = null!;
        public string username { get; set; } = null!;
        public string groupname { get; set; } = null!;
        public string? realm { get; set; }
        public string nasipaddress { get; set; } = null!;
        public string? nasportid { get; set; }
        public string? nasporttype { get; set; }
        public DateTime? acctstarttime { get; set; }
        public DateTime? acctstoptime { get; set; }
        public int? acctsessiontime { get; set; }
        public string? acctauthentic { get; set; }
        public string? connectinfo_start { get; set; }
        public string? connectinfo_stop { get; set; }
        public long? acctinputoctets { get; set; }
        public long? acctoutputoctets { get; set; }
        public string calledstationid { get; set; } = null!;
        public string callingstationid { get; set; } = null!;
        public string acctterminatecause { get; set; } = null!;
        public string? servicetype { get; set; }
        public string? framedprotocol { get; set; }
        public string framedipaddress { get; set; } = null!;
        public int? acctstartdelay { get; set; }
        public int? acctstopdelay { get; set; }
        public string? xascendsessionsvrkey { get; set; }
        public DateTime? _accttime { get; set; }
        public int? _srvid { get; set; }
        public bool? _dailynextsrvactive { get; set; }
        public int? _apid { get; set; }
    }
}

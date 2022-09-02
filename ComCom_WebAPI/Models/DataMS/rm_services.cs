using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_services
    {
        public int srvid { get; set; }
        public string srvname { get; set; } = null!;
        public string descr { get; set; } = null!;
        public int downrate { get; set; }
        public int uprate { get; set; }
        public bool limitdl { get; set; }
        public bool limitul { get; set; }
        public bool limitcomb { get; set; }
        public bool limitexpiration { get; set; }
        public bool limituptime { get; set; }
        public string poolname { get; set; } = null!;
        public decimal unitprice { get; set; }
        public decimal unitpriceadd { get; set; }
        public bool timebaseexp { get; set; }
        public bool timebaseonline { get; set; }
        public int timeunitexp { get; set; }
        public int timeunitonline { get; set; }
        public int trafficunitdl { get; set; }
        public int trafficunitul { get; set; }
        public int trafficunitcomb { get; set; }
        public int inittimeexp { get; set; }
        public int inittimeonline { get; set; }
        public int initdl { get; set; }
        public int initul { get; set; }
        public int inittotal { get; set; }
        public bool srvtype { get; set; }
        public bool timeaddmodeexp { get; set; }
        public bool timeaddmodeonline { get; set; }
        public bool trafficaddmode { get; set; }
        public bool monthly { get; set; }
        public bool enaddcredits { get; set; }
        public int minamount { get; set; }
        public int minamountadd { get; set; }
        public bool resetctrdate { get; set; }
        public bool resetctrneg { get; set; }
        public bool pricecalcdownload { get; set; }
        public bool pricecalcupload { get; set; }
        public bool pricecalcuptime { get; set; }
        public decimal unitpricetax { get; set; }
        public decimal unitpriceaddtax { get; set; }
        public bool enableburst { get; set; }
        public int dlburstlimit { get; set; }
        public int ulburstlimit { get; set; }
        public int dlburstthreshold { get; set; }
        public int ulburstthreshold { get; set; }
        public int dlbursttime { get; set; }
        public int ulbursttime { get; set; }
        public int enableservice { get; set; }
        public long dlquota { get; set; }
        public long ulquota { get; set; }
        public long combquota { get; set; }
        public long timequota { get; set; }
        public short priority { get; set; }
        public int nextsrvid { get; set; }
        public int dailynextsrvid { get; set; }
        public int disnextsrvid { get; set; }
        public bool availucp { get; set; }
        public bool renew { get; set; }
        public bool carryover { get; set; }
        public string policymapdl { get; set; } = null!;
        public string policymapul { get; set; } = null!;
        public string custattr { get; set; } = null!;
        public bool gentftp { get; set; }
        public string cmcfg { get; set; } = null!;
        public bool advcmcfg { get; set; }
        public int addamount { get; set; }
        public bool ignstatip { get; set; }
    }
}

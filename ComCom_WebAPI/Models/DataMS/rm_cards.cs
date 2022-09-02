using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_cards
    {
        public long id { get; set; }
        public string cardnum { get; set; } = null!;
        public string password { get; set; } = null!;
        public decimal value { get; set; }
        public string expiration { get; set; } = null!;
        public string series { get; set; } = null!;
        public string date { get; set; } = null!;
        public string owner { get; set; } = null!;
        public DateTime used { get; set; }
        public bool cardtype { get; set; }
        public bool revoked { get; set; }
        public long downlimit { get; set; }
        public long uplimit { get; set; }
        public long comblimit { get; set; }
        public long uptimelimit { get; set; }
        public int srvid { get; set; }
        public string transid { get; set; } = null!;
        public bool active { get; set; }
        public long expiretime { get; set; }
        public bool timebaseexp { get; set; }
        public bool timebaseonline { get; set; }
    }
}

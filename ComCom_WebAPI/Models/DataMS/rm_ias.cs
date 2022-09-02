using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_ias
    {
        public int iasid { get; set; }
        public string iasname { get; set; } = null!;
        public decimal price { get; set; }
        public long downlimit { get; set; }
        public long uplimit { get; set; }
        public long comblimit { get; set; }
        public long uptimelimit { get; set; }
        public long expiretime { get; set; }
        public bool timebaseonline { get; set; }
        public bool timebaseexp { get; set; }
        public int srvid { get; set; }
        public bool enableias { get; set; }
        public bool expiremode { get; set; }
        public string expiration { get; set; } = null!;
        public int simuse { get; set; }
    }
}

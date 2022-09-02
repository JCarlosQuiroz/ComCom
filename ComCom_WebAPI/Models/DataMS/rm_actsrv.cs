using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_actsrv
    {
        public long id { get; set; }
        public DateTime datetime { get; set; }
        public string username { get; set; } = null!;
        public int srvid { get; set; }
        public bool dailynextsrvactive { get; set; }
    }
}

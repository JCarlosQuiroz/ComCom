using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_newusers
    {
        public int id { get; set; }
        public string username { get; set; } = null!;
        public string firstname { get; set; } = null!;
        public string lastname { get; set; } = null!;
        public string address { get; set; } = null!;
        public string city { get; set; } = null!;
        public string zip { get; set; } = null!;
        public string country { get; set; } = null!;
        public string state { get; set; } = null!;
        public string phone { get; set; } = null!;
        public string mobile { get; set; } = null!;
        public string email { get; set; } = null!;
        public string vatid { get; set; } = null!;
        public int srvid { get; set; }
        public string actcode { get; set; } = null!;
        public int actcount { get; set; }
        public string lang { get; set; } = null!;
    }
}

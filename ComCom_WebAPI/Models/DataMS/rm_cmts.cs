using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_cmts
    {
        public int id { get; set; }
        public string ip { get; set; } = null!;
        public string name { get; set; } = null!;
        public string community { get; set; } = null!;
        public string descr { get; set; } = null!;
    }
}

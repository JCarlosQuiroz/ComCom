using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_ap
    {
        public int id { get; set; }
        public string name { get; set; } = null!;
        public bool enable { get; set; }
        public bool accessmode { get; set; }
        public string ip { get; set; } = null!;
        public string community { get; set; } = null!;
        public string apiusername { get; set; } = null!;
        public string apipassword { get; set; } = null!;
        public string description { get; set; } = null!;
    }
}

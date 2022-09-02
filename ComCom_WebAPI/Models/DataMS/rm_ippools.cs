using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_ippools
    {
        public int id { get; set; }
        public bool type { get; set; }
        public string name { get; set; } = null!;
        public string fromip { get; set; } = null!;
        public string toip { get; set; } = null!;
        public string descr { get; set; } = null!;
        public int nextpoolid { get; set; }
    }
}

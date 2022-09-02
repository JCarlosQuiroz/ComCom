using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class radpostauth
    {
        public int id { get; set; }
        public string username { get; set; } = null!;
        public string pass { get; set; } = null!;
        public string reply { get; set; } = null!;
        public DateTime authdate { get; set; }
        public string nasipaddress { get; set; } = null!;
    }
}

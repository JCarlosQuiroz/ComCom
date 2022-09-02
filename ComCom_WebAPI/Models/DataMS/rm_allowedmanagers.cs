using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_allowedmanagers
    {
        public int srvid { get; set; }
        public string managername { get; set; } = null!;
    }
}

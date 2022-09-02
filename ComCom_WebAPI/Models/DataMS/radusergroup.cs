using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class radusergroup
    {
        public string username { get; set; } = null!;
        public string groupname { get; set; } = null!;
        public int priority { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_usergroups
    {
        public int groupid { get; set; }
        public string groupname { get; set; } = null!;
        public string descr { get; set; } = null!;
    }
}

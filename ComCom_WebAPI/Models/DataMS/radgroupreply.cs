using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class radgroupreply
    {
        public uint id { get; set; }
        public string groupname { get; set; } = null!;
        public string attribute { get; set; } = null!;
        public string op { get; set; } = null!;
        public string value { get; set; } = null!;
    }
}

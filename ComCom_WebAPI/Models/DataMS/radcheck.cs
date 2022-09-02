using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class radcheck
    {
        public uint id { get; set; }
        public string username { get; set; } = null!;
        public string attribute { get; set; } = null!;
        public string op { get; set; } = null!;
        public string value { get; set; } = null!;
    }
}

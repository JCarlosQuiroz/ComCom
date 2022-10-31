using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class session
    {
        public string id { get; set; } = null!;
        public string name { get; set; } = null!;
        public int? modified { get; set; }
        public int? lifetime { get; set; }
        public byte[]? data { get; set; }
    }
}

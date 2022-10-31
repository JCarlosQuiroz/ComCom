using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_logs
    {
        public uint id_log { get; set; }
        public uint id_user { get; set; }
        public byte _event { get; set; }
        public string note { get; set; } = null!;
    }
}

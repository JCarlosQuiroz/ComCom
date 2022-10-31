using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_call_types
    {
        public uint id_call_type { get; set; }
        public string name { get; set; } = null!;
        public byte status { get; set; }
    }
}

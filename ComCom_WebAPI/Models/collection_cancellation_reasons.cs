using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_cancellation_reasons
    {
        public uint id_cancellation_reason { get; set; }
        public string description { get; set; } = null!;
        public byte status { get; set; }
        public DateTime timestamp { get; set; }
    }
}

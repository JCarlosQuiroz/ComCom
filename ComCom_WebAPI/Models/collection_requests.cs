using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_requests
    {
        public uint id_request { get; set; }
        public uint id_receipt { get; set; }
        public uint id_cancellation_reason { get; set; }
        public byte status { get; set; }
        public DateTime timestamp { get; set; }
        public string? note { get; set; }
        public DateTime? validation_date { get; set; }
    }
}

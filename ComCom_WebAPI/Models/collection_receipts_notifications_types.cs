using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_receipts_notifications_types
    {
        public uint id_receipt_notification_type { get; set; }
        public string name { get; set; } = null!;
        public string message { get; set; } = null!;
        public byte status { get; set; }
    }
}

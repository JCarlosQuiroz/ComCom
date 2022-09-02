using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_receipts_notifications
    {
        public uint id_receipt_notification { get; set; }
        public uint id_receipt { get; set; }
        public uint id_receipt_notification_type { get; set; }
        public DateTime timestamp { get; set; }
        public sbyte seen { get; set; }
    }
}

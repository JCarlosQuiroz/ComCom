using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_receipts_logs
    {
        public uint id_receipt_log { get; set; }
        public uint id_receipt { get; set; }
        public ulong id_log { get; set; }

        public virtual collection_logs id_logNavigation { get; set; } = null!;
        public virtual collection_receipts id_receiptNavigation { get; set; } = null!;
    }
}

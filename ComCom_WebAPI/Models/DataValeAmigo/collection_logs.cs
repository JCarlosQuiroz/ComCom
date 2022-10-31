using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_logs
    {
        public collection_logs()
        {
            collection_receipts_logs = new HashSet<collection_receipts_logs>();
        }

        public ulong id_log { get; set; }
        public uint id_user { get; set; }
        public byte _event { get; set; }
        public DateTime timestamp { get; set; }
        public string? note { get; set; }

        public virtual core_users id_userNavigation { get; set; } = null!;
        public virtual ICollection<collection_receipts_logs> collection_receipts_logs { get; set; }
    }
}

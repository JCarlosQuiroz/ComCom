using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_receipt_requests
    {
        public uint id_receipt_request { get; set; }
        public uint id_branch { get; set; }
        public uint id_user { get; set; }
        public byte status { get; set; }
        public uint quantity { get; set; }
        public DateOnly request_date { get; set; }
        public DateTime timestamp { get; set; }

        public virtual core_branches id_branchNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}

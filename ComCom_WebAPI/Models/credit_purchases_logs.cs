using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_purchases_logs
    {
        public uint id_purchase_log { get; set; }
        public uint id_purchase { get; set; }
        public uint id_user { get; set; }
        public byte _event { get; set; }
        public DateTime created { get; set; }
        public string? note { get; set; }

        public virtual credit_puchases id_purchaseNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}

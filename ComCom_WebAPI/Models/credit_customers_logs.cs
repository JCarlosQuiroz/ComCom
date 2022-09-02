using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_customers_logs
    {
        public uint id_customer_log { get; set; }
        public uint id_customer { get; set; }
        public uint? id_user { get; set; }
        public byte _event { get; set; }
        public DateTime datetime { get; set; }
        public string note { get; set; } = null!;

        public virtual credit_customers id_customerNavigation { get; set; } = null!;
        public virtual core_users? id_userNavigation { get; set; }
    }
}

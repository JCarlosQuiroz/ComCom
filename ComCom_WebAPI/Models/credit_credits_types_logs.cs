using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_credits_types_logs
    {
        public uint id_credit_type_log { get; set; }
        public uint id_credit_type { get; set; }
        public uint id_user { get; set; }
        public DateTime datetime { get; set; }
        public byte _event { get; set; }
        public string note { get; set; } = null!;

        public virtual credit_credits_types id_credit_typeNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}

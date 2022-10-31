using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_credits_automatic_locks
    {
        public uint id_credit_automatic_lock { get; set; }
        public uint id_credit { get; set; }
        public uint id_automatic_lock { get; set; }
        public DateOnly start { get; set; }
        public DateOnly end { get; set; }
        public uint due_days { get; set; }
        public decimal balance { get; set; }

        public virtual credit_automatic_locks id_automatic_lockNavigation { get; set; } = null!;
        public virtual credit_credits id_creditNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_automatic_locks
    {
        public credit_automatic_locks()
        {
            credit_credits = new HashSet<credit_credits>();
            credit_credits_automatic_locks = new HashSet<credit_credits_automatic_locks>();
        }

        public uint id_automatic_lock { get; set; }
        public byte status { get; set; }
        public byte type { get; set; }
        public uint start { get; set; }
        public uint end { get; set; }
        public uint days { get; set; }
        public byte apply_type { get; set; }

        public virtual ICollection<credit_credits> credit_credits { get; set; }
        public virtual ICollection<credit_credits_automatic_locks> credit_credits_automatic_locks { get; set; }
    }
}

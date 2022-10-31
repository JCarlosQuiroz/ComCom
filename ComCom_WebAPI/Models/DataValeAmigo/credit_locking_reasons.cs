using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_locking_reasons
    {
        public credit_locking_reasons()
        {
            credit_credits = new HashSet<credit_credits>();
        }

        public uint id_locking_reason { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;
        public string? description { get; set; }

        public virtual ICollection<credit_credits> credit_credits { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_cancellation_reasons
    {
        public credit_cancellation_reasons()
        {
            credit_requests = new HashSet<credit_requests>();
        }

        public uint id_cancellation_reason { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;

        public virtual ICollection<credit_requests> credit_requests { get; set; }
    }
}

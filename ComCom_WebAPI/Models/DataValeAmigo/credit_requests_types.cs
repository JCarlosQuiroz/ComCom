using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_requests_types
    {
        public credit_requests_types()
        {
            credit_requests = new HashSet<credit_requests>();
            id_role = new HashSet<core_roles>();
        }

        public uint id_request_type { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;

        public virtual ICollection<credit_requests> credit_requests { get; set; }

        public virtual ICollection<core_roles> id_role { get; set; }
    }
}

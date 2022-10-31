using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_roles
    {
        public core_roles()
        {
            id_action = new HashSet<core_actions>();
            id_request_type = new HashSet<credit_requests_types>();
            id_stage = new HashSet<origination_stages>();
            id_user = new HashSet<core_users>();
        }

        public uint id_role { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;

        public virtual ICollection<core_actions> id_action { get; set; }
        public virtual ICollection<credit_requests_types> id_request_type { get; set; }
        public virtual ICollection<origination_stages> id_stage { get; set; }
        public virtual ICollection<core_users> id_user { get; set; }
    }
}

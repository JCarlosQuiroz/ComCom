using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_protections_requests_alerts
    {
        public uint id_protection_request_alert { get; set; }
        public uint id_protection_request { get; set; }
        public uint? id_user { get; set; }
        public DateTime datetime { get; set; }
        public string alert { get; set; } = null!;
        public uint? reject { get; set; }

        public virtual credit_protections_requests id_protection_requestNavigation { get; set; } = null!;
        public virtual core_users? id_userNavigation { get; set; }
    }
}

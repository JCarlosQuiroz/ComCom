using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_alerts
    {
        public uint id_alert { get; set; }
        public uint id_application { get; set; }
        public uint? id_user { get; set; }
        public DateTime datetime { get; set; }
        public string alert { get; set; } = null!;
        public uint? reject { get; set; }

        public virtual origination_applications id_applicationNavigation { get; set; } = null!;
        public virtual core_users? id_userNavigation { get; set; }
    }
}

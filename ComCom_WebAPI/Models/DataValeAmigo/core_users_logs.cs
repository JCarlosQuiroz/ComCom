using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_users_logs
    {
        public uint id_user_log { get; set; }
        public uint id_user { get; set; }
        public uint id_log { get; set; }

        public virtual core_logs id_logNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}

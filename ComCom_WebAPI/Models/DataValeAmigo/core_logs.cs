using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_logs
    {
        public core_logs()
        {
            core_users_logs = new HashSet<core_users_logs>();
        }

        public uint id_log { get; set; }
        public uint id_user { get; set; }
        public byte _event { get; set; }
        public DateTime timestamp { get; set; }
        public string? note { get; set; }

        public virtual core_users id_userNavigation { get; set; } = null!;
        public virtual ICollection<core_users_logs> core_users_logs { get; set; }
    }
}

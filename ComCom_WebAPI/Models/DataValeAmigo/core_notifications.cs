using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_notifications
    {
        public uint id_notification { get; set; }
        public uint id_user { get; set; }
        public uint? id_from { get; set; }
        public byte status { get; set; }
        public byte type { get; set; }
        public string title { get; set; } = null!;
        public string? url { get; set; }
        public string message { get; set; } = null!;
        public DateTime timestamp { get; set; }

        public virtual core_users? id_fromNavigation { get; set; }
        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}

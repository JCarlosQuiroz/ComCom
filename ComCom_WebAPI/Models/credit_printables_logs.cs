using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_printables_logs
    {
        public uint id_printable_log { get; set; }
        public uint id_printable { get; set; }
        public uint id_user { get; set; }
        public byte _event { get; set; }
        public DateTime registered { get; set; }
        public string? note { get; set; }

        public virtual credit_printables id_printableNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_supervisors
    {
        public uint id_supervisor { get; set; }
        public uint id_user { get; set; }

        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}

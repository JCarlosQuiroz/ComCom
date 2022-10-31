using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credinet_configuration
    {
        public uint id_configuration { get; set; }
        public uint id_user { get; set; }
        public uint id_stage { get; set; }
        public string? token { get; set; }
        public DateTime created { get; set; }

        public virtual origination_stages id_stageNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}

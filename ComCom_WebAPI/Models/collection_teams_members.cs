using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_teams_members
    {
        public uint id_team_member { get; set; }
        public uint id_team { get; set; }
        public uint id_user { get; set; }
        public byte type { get; set; }

        public virtual collection_teams id_teamNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}

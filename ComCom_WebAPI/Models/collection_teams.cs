using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_teams
    {
        public collection_teams()
        {
            collection_coordinations = new HashSet<collection_coordinations>();
            collection_teams_members = new HashSet<collection_teams_members>();
        }

        public uint id_team { get; set; }
        public uint id_user { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;

        public virtual core_users id_userNavigation { get; set; } = null!;
        public virtual ICollection<collection_coordinations> collection_coordinations { get; set; }
        public virtual ICollection<collection_teams_members> collection_teams_members { get; set; }
    }
}

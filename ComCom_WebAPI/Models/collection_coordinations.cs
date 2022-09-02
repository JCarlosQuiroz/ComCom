using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_coordinations
    {
        public collection_coordinations()
        {
            closure_closures_entries = new HashSet<closure_closures_entries>();
            collection_assignments = new HashSet<collection_assignments>();
            collection_managements = new HashSet<collection_managements>();
        }

        public uint id_coordination { get; set; }
        public uint id_branch { get; set; }
        public uint id_type { get; set; }
        public uint id_team { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;
        public uint max { get; set; }
        public uint? id_user { get; set; }

        public virtual core_branches id_branchNavigation { get; set; } = null!;
        public virtual collection_teams id_teamNavigation { get; set; } = null!;
        public virtual collection_types id_typeNavigation { get; set; } = null!;
        public virtual core_users? id_userNavigation { get; set; }
        public virtual ICollection<closure_closures_entries> closure_closures_entries { get; set; }
        public virtual ICollection<collection_assignments> collection_assignments { get; set; }
        public virtual ICollection<collection_managements> collection_managements { get; set; }
    }
}

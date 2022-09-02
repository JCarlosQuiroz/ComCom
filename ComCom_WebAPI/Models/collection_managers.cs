using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_managers
    {
        public collection_managers()
        {
            collection_mangements = new HashSet<collection_mangements>();
            collection_tasks = new HashSet<collection_tasks>();
            id_groupNavigation = new HashSet<collection_groups>();
        }

        public uint id_manager { get; set; }
        public uint id_group { get; set; }
        public uint id_user { get; set; }
        public uint id_employment { get; set; }

        public virtual collection_employments id_employmentNavigation { get; set; } = null!;
        public virtual collection_groups id_group1 { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
        public virtual ICollection<collection_mangements> collection_mangements { get; set; }
        public virtual ICollection<collection_tasks> collection_tasks { get; set; }

        public virtual ICollection<collection_groups> id_groupNavigation { get; set; }
    }
}

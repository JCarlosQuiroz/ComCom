using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_groups
    {
        public collection_groups()
        {
            collection_group_zipcodes = new HashSet<collection_group_zipcodes>();
            collection_managers = new HashSet<collection_managers>();
            id_distributor = new HashSet<credit_distributors>();
            id_manager = new HashSet<collection_managers>();
        }

        public uint id_group { get; set; }
        public uint id_branch { get; set; }
        public uint id_type { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;

        public virtual core_branches id_branchNavigation { get; set; } = null!;
        public virtual collection_types id_typeNavigation { get; set; } = null!;
        public virtual ICollection<collection_group_zipcodes> collection_group_zipcodes { get; set; }
        public virtual ICollection<collection_managers> collection_managers { get; set; }

        public virtual ICollection<credit_distributors> id_distributor { get; set; }
        public virtual ICollection<collection_managers> id_manager { get; set; }
    }
}

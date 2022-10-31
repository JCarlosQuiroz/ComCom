using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_zones
    {
        public core_zones()
        {
            core_branches = new HashSet<core_branches>();
            credit_puchases = new HashSet<credit_puchases>();
        }

        public uint id_zone { get; set; }
        public string name { get; set; } = null!;
        public byte status { get; set; }

        public virtual ICollection<core_branches> core_branches { get; set; }
        public virtual ICollection<credit_puchases> credit_puchases { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_scorings
    {
        public origination_scorings()
        {
            origination_scoring_approval_conditions = new HashSet<origination_scoring_approval_conditions>();
            origination_scoring_fields = new HashSet<origination_scoring_fields>();
        }

        public uint id_scoring { get; set; }
        public uint id_user { get; set; }
        public DateTime timestamp { get; set; }
        public string name { get; set; } = null!;
        public byte status { get; set; }
        public string? description { get; set; }
        public uint id_process { get; set; }
        public byte person_type { get; set; }

        public virtual origination_processes id_processNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
        public virtual ICollection<origination_scoring_approval_conditions> origination_scoring_approval_conditions { get; set; }
        public virtual ICollection<origination_scoring_fields> origination_scoring_fields { get; set; }
    }
}

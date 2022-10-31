using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_scoring_approval_conditions
    {
        public uint id_scoring_approval_condition { get; set; }
        public uint id_scoring { get; set; }
        public uint id_user { get; set; }
        public byte status { get; set; }
        public byte approved { get; set; }
        public uint value { get; set; }
        public DateTime timestamp { get; set; }

        public virtual origination_scorings id_scoringNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}

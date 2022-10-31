using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_scoring_fields
    {
        public origination_scoring_fields()
        {
            origination_scoring_field_answers = new HashSet<origination_scoring_field_answers>();
        }

        public uint id_scoring_field { get; set; }
        public uint id_scoring { get; set; }
        public uint id_user { get; set; }
        public DateTime timestamp { get; set; }
        public string name { get; set; } = null!;
        public byte status { get; set; }

        public virtual origination_scorings id_scoringNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
        public virtual ICollection<origination_scoring_field_answers> origination_scoring_field_answers { get; set; }
    }
}

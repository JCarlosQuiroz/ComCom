using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_configurations_interests
    {
        public credit_configurations_interests()
        {
            core_branches = new HashSet<core_branches>();
            credit_configurations_interests_logs = new HashSet<credit_configurations_interests_logs>();
            credit_interests = new HashSet<credit_interests>();
        }

        public uint id_configuration_interest { get; set; }
        public string name { get; set; } = null!;
        public DateTime date_register { get; set; }
        public sbyte status { get; set; }

        public virtual ICollection<core_branches> core_branches { get; set; }
        public virtual ICollection<credit_configurations_interests_logs> credit_configurations_interests_logs { get; set; }
        public virtual ICollection<credit_interests> credit_interests { get; set; }
    }
}

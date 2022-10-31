using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_configurations_interests_logs
    {
        public uint id_configuration_interest_log { get; set; }
        public uint id_configuration_interest { get; set; }
        public uint id_user { get; set; }
        public DateTime created { get; set; }
        public sbyte _event { get; set; }
        public string note { get; set; } = null!;

        public virtual credit_configurations_interests id_configuration_interestNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}

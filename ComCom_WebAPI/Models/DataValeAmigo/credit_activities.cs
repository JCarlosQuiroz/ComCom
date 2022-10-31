using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_activities
    {
        public uint id_activity { get; set; }
        public uint id_credit { get; set; }
        public uint id_distributor { get; set; }
        public DateTime datetime { get; set; }
        public string note { get; set; } = null!;

        public virtual credit_credits id_creditNavigation { get; set; } = null!;
        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
    }
}

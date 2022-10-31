using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_distributors_rivalries
    {
        public uint id_distributor_rivalry { get; set; }
        public uint id_distributor { get; set; }
        public uint id_credit { get; set; }
        public uint id_rivalry { get; set; }
        public byte antiquity { get; set; }
        public decimal sold { get; set; }
        public decimal credit_line { get; set; }

        public virtual credit_credits id_creditNavigation { get; set; } = null!;
        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual origination_rivalries id_rivalryNavigation { get; set; } = null!;
    }
}

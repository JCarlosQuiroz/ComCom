using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_interests
    {
        public uint id_interest { get; set; }
        public uint id_fortnight { get; set; }
        public uint id_amount { get; set; }
        public uint? id_charge_type { get; set; }
        public decimal interest { get; set; }
        public uint id_configuration_interest { get; set; }
        public int? id_category { get; set; }

        public virtual credit_amounts id_amountNavigation { get; set; } = null!;
        public virtual credit_charge_type? id_charge_typeNavigation { get; set; }
        public virtual credit_configurations_interests id_configuration_interestNavigation { get; set; } = null!;
        public virtual credit_fortnights id_fortnightNavigation { get; set; } = null!;
    }
}

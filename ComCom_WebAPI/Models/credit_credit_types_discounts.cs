using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_credit_types_discounts
    {
        public uint id_credit_type_discount { get; set; }
        public uint? id_credit_type { get; set; }
        public uint id_charge_type { get; set; }
        public uint id_category { get; set; }
        public int due_days { get; set; }
        public decimal discount { get; set; }
        public int? id_configuration_discount { get; set; }

        public virtual credit_categories id_categoryNavigation { get; set; } = null!;
        public virtual credit_charge_type id_charge_typeNavigation { get; set; } = null!;
        public virtual credit_credits_types? id_credit_typeNavigation { get; set; }
    }
}

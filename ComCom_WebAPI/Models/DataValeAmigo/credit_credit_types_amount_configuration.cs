using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_credit_types_amount_configuration
    {
        public uint id_amount_configuration { get; set; }
        public uint id_credit_type { get; set; }
        public decimal limit_amount { get; set; }
        public decimal limit_amount_first { get; set; }
        public sbyte status { get; set; }

        public virtual credit_credits_types id_credit_typeNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_credits_types_limits
    {
        public uint id_credit_type_limit { get; set; }
        public uint id_credit_type { get; set; }
        public decimal limit { get; set; }
        public uint guarantees { get; set; }
        public byte property { get; set; }

        public virtual credit_credits_types id_credit_typeNavigation { get; set; } = null!;
    }
}

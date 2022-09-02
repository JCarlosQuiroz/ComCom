using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_distributors_extra_fields
    {
        public uint id_distributor_extra_field { get; set; }
        public uint id_distributor { get; set; }
        public uint id_credit { get; set; }
        public uint id_extra_field { get; set; }
        public string value { get; set; } = null!;
        public byte entity { get; set; }

        public virtual credit_credits id_creditNavigation { get; set; } = null!;
        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual origination_extra_fields id_extra_fieldNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_fortnights
    {
        public credit_fortnights()
        {
            credit_interests = new HashSet<credit_interests>();
        }

        public uint id_fortnight { get; set; }
        public uint? id_charge_type { get; set; }
        public byte status { get; set; }
        public uint fortnight { get; set; }

        public virtual credit_charge_type? id_charge_typeNavigation { get; set; }
        public virtual ICollection<credit_interests> credit_interests { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_charge_type
    {
        public credit_charge_type()
        {
            coupon_coupons = new HashSet<coupon_coupons>();
            credit_amounts = new HashSet<credit_amounts>();
            credit_charges = new HashSet<credit_charges>();
            credit_credit_types_discounts = new HashSet<credit_credit_types_discounts>();
            credit_fortnights = new HashSet<credit_fortnights>();
            credit_interests = new HashSet<credit_interests>();
            credit_puchases = new HashSet<credit_puchases>();
        }

        public uint id_charge_type { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;
        public byte requires_confirmation { get; set; }
        public byte affects_credit_line { get; set; }
        public byte amount_from { get; set; }
        public byte is_simultaneous { get; set; }
        public decimal amount { get; set; }

        public virtual ICollection<coupon_coupons> coupon_coupons { get; set; }
        public virtual ICollection<credit_amounts> credit_amounts { get; set; }
        public virtual ICollection<credit_charges> credit_charges { get; set; }
        public virtual ICollection<credit_credit_types_discounts> credit_credit_types_discounts { get; set; }
        public virtual ICollection<credit_fortnights> credit_fortnights { get; set; }
        public virtual ICollection<credit_interests> credit_interests { get; set; }
        public virtual ICollection<credit_puchases> credit_puchases { get; set; }
    }
}

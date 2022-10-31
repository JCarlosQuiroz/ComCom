using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_amounts
    {
        public credit_amounts()
        {
            coupon_coupons = new HashSet<coupon_coupons>();
            credit_amount_brancheslimit_id_amountNavigation = new HashSet<credit_amount_branches>();
            credit_amount_brancheslimit_id_amount_firstNavigation = new HashSet<credit_amount_branches>();
            credit_interests = new HashSet<credit_interests>();
        }

        public uint id_amount { get; set; }
        public uint? id_charge_type { get; set; }
        public byte status { get; set; }
        public decimal amount { get; set; }

        public virtual credit_charge_type? id_charge_typeNavigation { get; set; }
        public virtual ICollection<coupon_coupons> coupon_coupons { get; set; }
        public virtual ICollection<credit_amount_branches> credit_amount_brancheslimit_id_amountNavigation { get; set; }
        public virtual ICollection<credit_amount_branches> credit_amount_brancheslimit_id_amount_firstNavigation { get; set; }
        public virtual ICollection<credit_interests> credit_interests { get; set; }
    }
}

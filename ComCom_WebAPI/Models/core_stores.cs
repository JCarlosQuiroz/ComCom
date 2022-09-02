using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_stores
    {
        public core_stores()
        {
            coupon_coupons = new HashSet<coupon_coupons>();
        }

        public uint id_store { get; set; }
        public uint id_branch { get; set; }
        public string name { get; set; } = null!;
        public byte status { get; set; }

        public virtual core_branches id_branchNavigation { get; set; } = null!;
        public virtual ICollection<coupon_coupons> coupon_coupons { get; set; }
    }
}

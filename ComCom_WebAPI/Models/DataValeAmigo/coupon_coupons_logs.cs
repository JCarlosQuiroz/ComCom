using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class coupon_coupons_logs
    {
        public uint id_coupon_log { get; set; }
        public uint id_coupon { get; set; }
        public uint id_user { get; set; }
        public byte _event { get; set; }
        public DateTime registered { get; set; }
        public string? note { get; set; }

        public virtual coupon_coupons id_couponNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}

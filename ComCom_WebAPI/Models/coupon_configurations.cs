using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class coupon_configurations
    {
        public coupon_configurations()
        {
            coupon_configurations_fields = new HashSet<coupon_configurations_fields>();
        }

        public uint id_configuration { get; set; }
        public uint id_user { get; set; }
        public byte status { get; set; }
        public byte coupons_per_page { get; set; }
        public string layout { get; set; } = null!;
        public DateOnly created_date { get; set; }
        public uint jump_between_coupons { get; set; }

        public virtual core_users id_userNavigation { get; set; } = null!;
        public virtual ICollection<coupon_configurations_fields> coupon_configurations_fields { get; set; }
    }
}

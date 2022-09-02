using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class coupon_configurations_vouchers
    {
        public coupon_configurations_vouchers()
        {
            coupon_configurations_vouchers_fields = new HashSet<coupon_configurations_vouchers_fields>();
        }

        public uint id_configuration_voucher { get; set; }
        public uint id_user { get; set; }
        public byte status { get; set; }
        public byte columns { get; set; }
        public byte rows { get; set; }
        public decimal column_space { get; set; }
        public decimal row_space { get; set; }
        public string layout { get; set; } = null!;
        public DateTime register_date { get; set; }
        public byte use_as { get; set; }
        public string identifier { get; set; } = null!;
        public byte typography { get; set; }

        public virtual core_users id_userNavigation { get; set; } = null!;
        public virtual ICollection<coupon_configurations_vouchers_fields> coupon_configurations_vouchers_fields { get; set; }
    }
}

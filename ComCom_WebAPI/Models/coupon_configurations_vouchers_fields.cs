using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class coupon_configurations_vouchers_fields
    {
        public uint id_configuration_voucher_field { get; set; }
        public uint id_configuration_voucher { get; set; }
        public decimal position_x { get; set; }
        public decimal position_y { get; set; }
        public byte type { get; set; }
        public byte typography { get; set; }

        public virtual coupon_configurations_vouchers id_configuration_voucherNavigation { get; set; } = null!;
    }
}

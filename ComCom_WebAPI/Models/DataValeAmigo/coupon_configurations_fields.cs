using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class coupon_configurations_fields
    {
        public uint id_configuration_field { get; set; }
        public uint id_configuration { get; set; }
        public byte field_type { get; set; }
        public decimal position_x { get; set; }
        public decimal position_y { get; set; }

        public virtual coupon_configurations id_configurationNavigation { get; set; } = null!;
    }
}

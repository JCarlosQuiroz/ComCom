using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_configurations_receipts_fields
    {
        public uint id_configuration_receipt_field { get; set; }
        public uint id_configuration_receipt { get; set; }
        public decimal position_x { get; set; }
        public decimal position_y { get; set; }
        public byte type { get; set; }

        public virtual credit_configurations_receipts id_configuration_receiptNavigation { get; set; } = null!;
    }
}

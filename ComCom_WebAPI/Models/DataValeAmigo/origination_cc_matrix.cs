using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_cc_matrix
    {
        public uint id_matrix { get; set; }
        public uint id_amount { get; set; }
        public uint id_status { get; set; }
        public byte type { get; set; }

        public virtual origination_cc_amounts id_amountNavigation { get; set; } = null!;
        public virtual origination_cc_statuses id_statusNavigation { get; set; } = null!;
    }
}

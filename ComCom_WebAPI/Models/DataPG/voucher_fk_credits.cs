using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class voucher_fk_credits
    {
        public int id { get; set; }
        public int voucher_id { get; set; }
        public int depositcredit_id { get; set; }

        public virtual deposit_credit depositcredit { get; set; } = null!;
        public virtual voucher voucher { get; set; } = null!;
    }
}

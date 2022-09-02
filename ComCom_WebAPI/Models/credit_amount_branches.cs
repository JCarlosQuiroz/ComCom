using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_amount_branches
    {
        public int id_amount_branch { get; set; }
        public int id_branch { get; set; }
        public uint limit_id_amount { get; set; }
        public uint limit_id_amount_first { get; set; }
        public int status { get; set; }

        public virtual credit_amounts limit_id_amountNavigation { get; set; } = null!;
        public virtual credit_amounts limit_id_amount_firstNavigation { get; set; } = null!;
    }
}

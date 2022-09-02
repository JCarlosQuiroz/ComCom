using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class type_debit_credit
    {
        public type_debit_credit()
        {
            deposit_credit = new HashSet<deposit_credit>();
            deposit_debit = new HashSet<deposit_debit>();
        }

        public int id { get; set; }
        public string? key { get; set; }
        public string? value { get; set; }
        public string type { get; set; } = null!;
        public bool is_active { get; set; }

        public virtual ICollection<deposit_credit> deposit_credit { get; set; }
        public virtual ICollection<deposit_debit> deposit_debit { get; set; }
    }
}

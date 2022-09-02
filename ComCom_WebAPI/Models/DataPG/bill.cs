using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class bill
    {
        public bill()
        {
            deposit_debit = new HashSet<deposit_debit>();
        }

        public int id { get; set; }
        public double amount { get; set; }
        public DateOnly created_date { get; set; }
        public DateOnly begin_date { get; set; }
        public DateOnly end_date { get; set; }
        public string bill_number { get; set; } = null!;
        public string client_name { get; set; } = null!;

        public virtual ICollection<deposit_debit> deposit_debit { get; set; }
    }
}

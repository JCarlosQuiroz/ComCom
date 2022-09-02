using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class deposit
    {
        public deposit()
        {
            client = new HashSet<client>();
            deposit_credit = new HashSet<deposit_credit>();
            deposit_debit = new HashSet<deposit_debit>();
            manager_business_client = new HashSet<manager_business_client>();
        }

        public int id { get; set; }
        public int amount { get; set; }
        public DateOnly? last_update_date { get; set; }
        public DateOnly? cut_off_date { get; set; }
        public bool billable { get; set; }
        public bool cut_off_by_script { get; set; }

        public virtual ICollection<client> client { get; set; }
        public virtual ICollection<deposit_credit> deposit_credit { get; set; }
        public virtual ICollection<deposit_debit> deposit_debit { get; set; }
        public virtual ICollection<manager_business_client> manager_business_client { get; set; }
    }
}

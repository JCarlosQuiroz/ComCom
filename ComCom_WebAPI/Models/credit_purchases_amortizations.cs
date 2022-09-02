using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_purchases_amortizations
    {
        public credit_purchases_amortizations()
        {
            credit_payments_entries_details = new HashSet<credit_payments_entries_details>();
            id_charge = new HashSet<credit_charges>();
        }

        public uint id_purchase_amortization { get; set; }
        public uint id_purchase { get; set; }
        public uint number { get; set; }
        public DateOnly date { get; set; }
        public decimal amount { get; set; }
        public decimal interest { get; set; }
        public decimal? insurance { get; set; }

        public virtual credit_puchases id_purchaseNavigation { get; set; } = null!;
        public virtual ICollection<credit_payments_entries_details> credit_payments_entries_details { get; set; }

        public virtual ICollection<credit_charges> id_charge { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_payments_entries_details
    {
        public uint id_payment_entry_detail { get; set; }
        public uint id_payment_entry { get; set; }
        public uint id_purchase_amortization { get; set; }
        public decimal amount { get; set; }
        public decimal principal { get; set; }
        public decimal interest { get; set; }
        public DateOnly? apply_date { get; set; }

        public virtual credit_payments_entries id_payment_entryNavigation { get; set; } = null!;
        public virtual credit_purchases_amortizations id_purchase_amortizationNavigation { get; set; } = null!;
    }
}

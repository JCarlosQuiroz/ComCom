using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_payments_entries
    {
        public credit_payments_entries()
        {
            credit_payments_entries_details = new HashSet<credit_payments_entries_details>();
        }

        public uint id_payment_entry { get; set; }
        public uint id_payment { get; set; }
        public uint? id_charge { get; set; }
        public uint? id_purchase { get; set; }
        public decimal amount { get; set; }
        public decimal principal { get; set; }
        public decimal interest { get; set; }
        public DateOnly? apply_date { get; set; }

        public virtual credit_charges? id_chargeNavigation { get; set; }
        public virtual credit_payments id_paymentNavigation { get; set; } = null!;
        public virtual credit_puchases? id_purchaseNavigation { get; set; }
        public virtual ICollection<credit_payments_entries_details> credit_payments_entries_details { get; set; }
    }
}

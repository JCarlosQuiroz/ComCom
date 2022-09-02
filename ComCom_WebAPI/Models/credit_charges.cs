using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_charges
    {
        public credit_charges()
        {
            credit_payments_entries = new HashSet<credit_payments_entries>();
            credit_requests = new HashSet<credit_requests>();
            id_purchase_amortization = new HashSet<credit_purchases_amortizations>();
        }

        public uint id_charge { get; set; }
        public uint id_distributor { get; set; }
        public uint id_credit { get; set; }
        public uint id_charge_type { get; set; }
        public uint id_category { get; set; }
        public byte status { get; set; }
        public DateOnly date { get; set; }
        public DateOnly due_date { get; set; }
        public decimal amount { get; set; }
        public decimal principal { get; set; }
        public decimal? interest { get; set; }
        public decimal applied_discount { get; set; }
        public decimal applied_discount_percentage { get; set; }

        public virtual credit_charge_type id_charge_typeNavigation { get; set; } = null!;
        public virtual credit_credits id_creditNavigation { get; set; } = null!;
        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual ICollection<credit_payments_entries> credit_payments_entries { get; set; }
        public virtual ICollection<credit_requests> credit_requests { get; set; }

        public virtual ICollection<credit_purchases_amortizations> id_purchase_amortization { get; set; }
    }
}

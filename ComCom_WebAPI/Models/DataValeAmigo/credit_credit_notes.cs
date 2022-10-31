using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_credit_notes
    {
        public uint id_credit_note { get; set; }
        public uint id_user { get; set; }
        public uint id_distributor { get; set; }
        public uint id_credit { get; set; }
        public uint? id_payment { get; set; }
        public byte status { get; set; }
        public DateTime datetime { get; set; }
        public decimal amount { get; set; }
        public string note { get; set; } = null!;
        public DateOnly cutoff { get; set; }
        public int? id_user_cancellation { get; set; }
        public DateTime? cancellation_date { get; set; }

        public virtual credit_credits id_creditNavigation { get; set; } = null!;
        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual credit_payments? id_paymentNavigation { get; set; }
        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}

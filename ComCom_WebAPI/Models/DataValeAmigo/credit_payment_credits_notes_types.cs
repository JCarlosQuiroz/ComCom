using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_payment_credits_notes_types
    {
        public credit_payment_credits_notes_types()
        {
            credit_payments = new HashSet<credit_payments>();
            credit_requests = new HashSet<credit_requests>();
        }

        public uint id_payment_credit_note_type { get; set; }
        public string name { get; set; } = null!;
        public byte status { get; set; }
        public DateTime? date { get; set; }

        public virtual ICollection<credit_payments> credit_payments { get; set; }
        public virtual ICollection<credit_requests> credit_requests { get; set; }
    }
}

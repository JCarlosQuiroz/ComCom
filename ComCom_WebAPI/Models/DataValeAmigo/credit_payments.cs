using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_payments
    {
        public credit_payments()
        {
            Inverseid_parentNavigation = new HashSet<credit_payments>();
            credit_credit_notes = new HashSet<credit_credit_notes>();
            credit_payments_entries = new HashSet<credit_payments_entries>();
            treasury_boxes_payments = new HashSet<treasury_boxes_payments>();
        }

        public uint id_payment { get; set; }
        public uint id_distributor { get; set; }
        public uint id_credit { get; set; }
        public uint? id_customer { get; set; }
        public uint? id_parent { get; set; }
        public uint? id_purchase { get; set; }
        public uint? id_receipt { get; set; }
        public byte status { get; set; }
        public byte type { get; set; }
        public byte? subtype { get; set; }
        public DateOnly date { get; set; }
        public DateTime timestamp { get; set; }
        public decimal amount { get; set; }
        public DateTime? cancellation_date { get; set; }
        public decimal principal { get; set; }
        public decimal interest { get; set; }
        public uint? id_payment_credit_note_type { get; set; }

        public virtual credit_credits id_creditNavigation { get; set; } = null!;
        public virtual credit_customers? id_customerNavigation { get; set; }
        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual credit_payments? id_parentNavigation { get; set; }
        public virtual credit_payment_credits_notes_types? id_payment_credit_note_typeNavigation { get; set; }
        public virtual credit_puchases? id_purchaseNavigation { get; set; }
        public virtual collection_receipts? id_receiptNavigation { get; set; }
        public virtual ICollection<credit_payments> Inverseid_parentNavigation { get; set; }
        public virtual ICollection<credit_credit_notes> credit_credit_notes { get; set; }
        public virtual ICollection<credit_payments_entries> credit_payments_entries { get; set; }
        public virtual ICollection<treasury_boxes_payments> treasury_boxes_payments { get; set; }
    }
}

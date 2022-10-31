using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_receipts
    {
        public collection_receipts()
        {
            collection_receipts_logs = new HashSet<collection_receipts_logs>();
            credit_payments = new HashSet<credit_payments>();
        }

        public uint id_receipt { get; set; }
        public uint id_corp_receipt_book { get; set; }
        public uint? id_branch_receipt_book { get; set; }
        public uint? id_manager_receipt_book { get; set; }
        public uint? id_manager { get; set; }
        public uint? id_distributor { get; set; }
        public uint? id_box { get; set; }
        public byte status { get; set; }
        public DateOnly create_date { get; set; }
        public DateOnly? cancel_date { get; set; }
        public DateTime timestamp { get; set; }
        public decimal? amount { get; set; }

        public virtual treasury_boxes? id_boxNavigation { get; set; }
        public virtual collection_receipt_books? id_branch_receipt_bookNavigation { get; set; }
        public virtual collection_receipt_books id_corp_receipt_bookNavigation { get; set; } = null!;
        public virtual credit_distributors? id_distributorNavigation { get; set; }
        public virtual core_users? id_managerNavigation { get; set; }
        public virtual collection_receipt_books? id_manager_receipt_bookNavigation { get; set; }
        public virtual collection_managements? collection_managements { get; set; }
        public virtual ICollection<collection_receipts_logs> collection_receipts_logs { get; set; }
        public virtual ICollection<credit_payments> credit_payments { get; set; }
    }
}

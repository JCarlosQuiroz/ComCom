using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_receipt_books
    {
        public collection_receipt_books()
        {
            collection_receiptsid_branch_receipt_bookNavigation = new HashSet<collection_receipts>();
            collection_receiptsid_corp_receipt_bookNavigation = new HashSet<collection_receipts>();
            collection_receiptsid_manager_receipt_bookNavigation = new HashSet<collection_receipts>();
        }

        public uint id_receipt_book { get; set; }
        public uint? id_branch { get; set; }
        public uint? id_manager { get; set; }
        public byte status { get; set; }
        public byte type { get; set; }
        public uint? start_folio { get; set; }
        public uint? end_folio { get; set; }
        public uint quantity { get; set; }
        public DateOnly create_date { get; set; }
        public DateOnly? cancel_date { get; set; }
        public DateTime timestamp { get; set; }

        public virtual core_branches? id_branchNavigation { get; set; }
        public virtual core_users? id_managerNavigation { get; set; }
        public virtual ICollection<collection_receipts> collection_receiptsid_branch_receipt_bookNavigation { get; set; }
        public virtual ICollection<collection_receipts> collection_receiptsid_corp_receipt_bookNavigation { get; set; }
        public virtual ICollection<collection_receipts> collection_receiptsid_manager_receipt_bookNavigation { get; set; }
    }
}

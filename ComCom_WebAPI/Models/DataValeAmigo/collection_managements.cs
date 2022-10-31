using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_managements
    {
        public uint id_management { get; set; }
        public uint id_distributor { get; set; }
        public uint id_credit { get; set; }
        public uint id_assignment { get; set; }
        public uint id_user { get; set; }
        public uint id_coordination { get; set; }
        public uint id_result_type { get; set; }
        public uint? id_receipt { get; set; }
        public DateTime datetime { get; set; }
        public string note { get; set; } = null!;
        public decimal? amount { get; set; }
        public DateOnly? date { get; set; }

        public virtual collection_assignments id_assignmentNavigation { get; set; } = null!;
        public virtual collection_coordinations id_coordinationNavigation { get; set; } = null!;
        public virtual credit_credits id_creditNavigation { get; set; } = null!;
        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual collection_receipts? id_receiptNavigation { get; set; }
        public virtual collection_result_types id_result_typeNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}

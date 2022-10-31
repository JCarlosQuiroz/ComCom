using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_assignments
    {
        public collection_assignments()
        {
            collection_managements = new HashSet<collection_managements>();
        }

        public uint id_assignment { get; set; }
        public uint id_distributor { get; set; }
        public uint id_credit { get; set; }
        public uint id_coordination { get; set; }
        public uint id_type { get; set; }
        public DateOnly assigned_date { get; set; }
        public uint assigned_mora { get; set; }
        public decimal assigned_limit { get; set; }
        public decimal assigned_due_balance { get; set; }
        public decimal assigned_payable_balance { get; set; }
        public decimal assigned_current_balance { get; set; }
        public decimal assigned_total_balance { get; set; }
        public decimal assigned_available { get; set; }
        public DateOnly? released_date { get; set; }
        public uint? released_mora { get; set; }
        public decimal? released_limit { get; set; }
        public decimal? released_due_balance { get; set; }
        public decimal? released_payable_balance { get; set; }
        public decimal? released_current_balance { get; set; }
        public decimal? released_total_balance { get; set; }
        public decimal? released_available { get; set; }

        public virtual collection_coordinations id_coordinationNavigation { get; set; } = null!;
        public virtual credit_credits id_creditNavigation { get; set; } = null!;
        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual collection_types id_typeNavigation { get; set; } = null!;
        public virtual ICollection<collection_managements> collection_managements { get; set; }
    }
}

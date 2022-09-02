using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_expenses
    {
        public uint id_expense { get; set; }
        public uint id_distributor { get; set; }
        public uint id_expense_type { get; set; }
        public decimal amount { get; set; }

        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual origination_expenses_types id_expense_typeNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_expenses_types
    {
        public origination_expenses_types()
        {
            credit_expenses = new HashSet<credit_expenses>();
            origination_expenses = new HashSet<origination_expenses>();
        }

        public uint id_expense_type { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;

        public virtual ICollection<credit_expenses> credit_expenses { get; set; }
        public virtual ICollection<origination_expenses> origination_expenses { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_categories
    {
        public credit_categories()
        {
            closure_closures_entries = new HashSet<closure_closures_entries>();
            credit_credit_types_discounts = new HashSet<credit_credit_types_discounts>();
            credit_distributors = new HashSet<credit_distributors>();
            credit_personal_loan_requeriments = new HashSet<credit_personal_loan_requeriments>();
        }

        public uint id_category { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;
        public decimal start_amount { get; set; }
        public decimal end_amount { get; set; }
        public byte calculated_by { get; set; }
        public string? filename { get; set; }

        public virtual ICollection<closure_closures_entries> closure_closures_entries { get; set; }
        public virtual ICollection<credit_credit_types_discounts> credit_credit_types_discounts { get; set; }
        public virtual ICollection<credit_distributors> credit_distributors { get; set; }
        public virtual ICollection<credit_personal_loan_requeriments> credit_personal_loan_requeriments { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_credits_types
    {
        public credit_credits_types()
        {
            credit_credit_types_amount_configuration = new HashSet<credit_credit_types_amount_configuration>();
            credit_credit_types_discounts = new HashSet<credit_credit_types_discounts>();
            credit_credits = new HashSet<credit_credits>();
            credit_credits_types_limits = new HashSet<credit_credits_types_limits>();
            credit_credits_types_logs = new HashSet<credit_credits_types_logs>();
        }

        public uint id_credit_type { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;
        public uint experience { get; set; }
        public decimal minimum_fortnightly { get; set; }
        public decimal minimum_sold { get; set; }
        public uint minimum_scoring { get; set; }
        public decimal inital { get; set; }
        public double? promissory_note { get; set; }
        public byte automatic_increase_decrement { get; set; }

        public virtual ICollection<credit_credit_types_amount_configuration> credit_credit_types_amount_configuration { get; set; }
        public virtual ICollection<credit_credit_types_discounts> credit_credit_types_discounts { get; set; }
        public virtual ICollection<credit_credits> credit_credits { get; set; }
        public virtual ICollection<credit_credits_types_limits> credit_credits_types_limits { get; set; }
        public virtual ICollection<credit_credits_types_logs> credit_credits_types_logs { get; set; }
    }
}

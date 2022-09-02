using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_configurations
    {
        public credit_configurations()
        {
            credit_credits = new HashSet<credit_credits>();
        }

        public uint id_configuration { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;
        public byte first_cutoff_date { get; set; }
        public byte second_cutoff_date { get; set; }
        public byte first_due_date { get; set; }
        public byte second_due_date { get; set; }
        public byte saturday_business { get; set; }
        public byte sunday_bussiness { get; set; }
        public byte next_or_previous { get; set; }
        public DateTime created { get; set; }
        public byte show_without_discounts { get; set; }
        public byte show_inactive_weekend { get; set; }
        public byte show_holidays { get; set; }

        public virtual ICollection<credit_credits> credit_credits { get; set; }
    }
}

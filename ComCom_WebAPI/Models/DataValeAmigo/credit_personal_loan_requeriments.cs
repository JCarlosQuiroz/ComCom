using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_personal_loan_requeriments
    {
        public uint id_personal_requeriment { get; set; }
        public uint id_user { get; set; }
        public byte status { get; set; }
        public DateOnly created_date { get; set; }
        public uint id_category { get; set; }
        public uint months { get; set; }
        public decimal limit_amount { get; set; }
        public byte cutoffs { get; set; }
        public uint min_due_day { get; set; }
        public uint max_due_day { get; set; }
        public decimal min_placed { get; set; }
        public decimal max_placed { get; set; }
        public decimal min_payment { get; set; }
        public decimal max_payment { get; set; }
        public decimal limit_amount_new { get; set; }

        public virtual credit_categories id_categoryNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}

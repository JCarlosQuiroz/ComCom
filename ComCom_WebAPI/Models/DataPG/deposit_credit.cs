using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class deposit_credit
    {
        public deposit_credit()
        {
            voucher_fk_credits = new HashSet<voucher_fk_credits>();
        }

        public int id { get; set; }
        public int amount { get; set; }
        public DateOnly? created_date { get; set; }
        public string? description { get; set; }
        public string? payment_concepts { get; set; }
        public bool is_active { get; set; }
        public int? created_by_id { get; set; }
        public int fk_deposit_id { get; set; }
        public int? fk_type_credit_id { get; set; }

        public virtual auth_user? created_by { get; set; }
        public virtual deposit fk_deposit { get; set; } = null!;
        public virtual type_debit_credit? fk_type_credit { get; set; }
        public virtual ICollection<voucher_fk_credits> voucher_fk_credits { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class deposit_debit
    {
        public int id { get; set; }
        public int amount { get; set; }
        public DateOnly? created_date { get; set; }
        public string? description { get; set; }
        public string? key { get; set; }
        public bool billed { get; set; }
        public DateOnly? billed_date { get; set; }
        public bool is_active { get; set; }
        public int? created_by_id { get; set; }
        public int? fk_bill_id { get; set; }
        public int fk_deposit_id { get; set; }
        public int? fk_type_debit_id { get; set; }

        public virtual auth_user? created_by { get; set; }
        public virtual bill? fk_bill { get; set; }
        public virtual deposit fk_deposit { get; set; } = null!;
        public virtual type_debit_credit? fk_type_debit { get; set; }
    }
}

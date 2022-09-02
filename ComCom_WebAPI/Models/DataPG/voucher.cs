using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class voucher
    {
        public voucher()
        {
            voucher_fk_credits = new HashSet<voucher_fk_credits>();
        }

        public int id { get; set; }
        public string code { get; set; } = null!;
        public DateOnly created_date { get; set; }
        public int? created_by_id { get; set; }
        public int fk_client_id { get; set; }

        public virtual auth_user? created_by { get; set; }
        public virtual client fk_client { get; set; } = null!;
        public virtual ICollection<voucher_fk_credits> voucher_fk_credits { get; set; }
    }
}

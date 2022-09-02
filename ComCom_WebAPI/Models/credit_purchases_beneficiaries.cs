using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_purchases_beneficiaries
    {
        public uint id_purchase_beneficiary { get; set; }
        public uint id_purchase { get; set; }
        public uint id_beneficiary { get; set; }
        public decimal percentage { get; set; }
        public DateTime register_date { get; set; }

        public virtual credit_beneficiaries id_beneficiaryNavigation { get; set; } = null!;
        public virtual credit_puchases id_purchaseNavigation { get; set; } = null!;
    }
}

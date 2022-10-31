using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_contracts
    {
        public uint id_contract { get; set; }
        public uint id_distributor { get; set; }
        public uint id_credit { get; set; }
        public string filename { get; set; } = null!;
        public string name { get; set; } = null!;
        public DateTime create_date { get; set; }
        public sbyte status { get; set; }

        public virtual credit_credits id_creditNavigation { get; set; } = null!;
        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
    }
}

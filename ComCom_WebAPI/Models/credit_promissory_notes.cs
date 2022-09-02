using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_promissory_notes
    {
        public uint id_promissory_note { get; set; }
        public uint id_distributor { get; set; }
        public uint id_credit { get; set; }
        public byte status { get; set; }
        public string filename { get; set; } = null!;
        public string name { get; set; } = null!;
        public DateTime upload_date { get; set; }
        public DateTime? released_date { get; set; }
        public decimal amount { get; set; }

        public virtual credit_credits id_creditNavigation { get; set; } = null!;
        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
    }
}

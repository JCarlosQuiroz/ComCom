using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_printables
    {
        public credit_printables()
        {
            credit_printables_logs = new HashSet<credit_printables_logs>();
        }

        public uint id_printable { get; set; }
        public uint id_distributor { get; set; }
        public uint id_credit { get; set; }
        public uint id_configuration_printable { get; set; }
        public string name { get; set; } = null!;
        public string filename { get; set; } = null!;
        public decimal? amount { get; set; }
        public byte status { get; set; }
        public DateTime upload_date { get; set; }

        public virtual origination_configurations_printables id_configuration_printableNavigation { get; set; } = null!;
        public virtual credit_credits id_creditNavigation { get; set; } = null!;
        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual ICollection<credit_printables_logs> credit_printables_logs { get; set; }
    }
}

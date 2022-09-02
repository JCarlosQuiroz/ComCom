using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class piorpi_alerts_entries
    {
        public piorpi_alerts_entries()
        {
            id_purchase = new HashSet<credit_puchases>();
        }

        public uint id_alert_entry { get; set; }
        public uint id_alert { get; set; }
        public uint id_distributor { get; set; }
        public DateOnly date { get; set; }
        public decimal amount { get; set; }

        public virtual piorpi_alerts id_alertNavigation { get; set; } = null!;
        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;

        public virtual ICollection<credit_puchases> id_purchase { get; set; }
    }
}

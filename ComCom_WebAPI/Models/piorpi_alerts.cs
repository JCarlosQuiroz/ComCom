using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class piorpi_alerts
    {
        public piorpi_alerts()
        {
            piorpi_alerts_entries = new HashSet<piorpi_alerts_entries>();
        }

        public uint id_alert { get; set; }
        public uint id_user { get; set; }
        public byte status { get; set; }
        public DateOnly date { get; set; }
        public decimal amount { get; set; }
        public uint alerts { get; set; }
        public DateTime timestamp { get; set; }
        public byte percentage { get; set; }

        public virtual core_users id_userNavigation { get; set; } = null!;
        public virtual ICollection<piorpi_alerts_entries> piorpi_alerts_entries { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class treasury_requests
    {
        public treasury_requests()
        {
            treasury_providers_requests = new HashSet<treasury_providers_requests>();
        }

        public uint id_request { get; set; }
        public uint id_provider { get; set; }
        public byte status { get; set; }
        public DateTime timestamp { get; set; }
        public string reference { get; set; } = null!;
        public decimal amount { get; set; }

        public virtual treasury_providers id_providerNavigation { get; set; } = null!;
        public virtual ICollection<treasury_providers_requests> treasury_providers_requests { get; set; }
    }
}

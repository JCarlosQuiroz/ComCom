using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_distributors_signatures_logs
    {
        public int id_signature_log { get; set; }
        public uint id_distributor { get; set; }
        public uint id_user { get; set; }
        public byte[] signature { get; set; } = null!;
        public DateTime created { get; set; }
        public string note { get; set; } = null!;

        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual core_users id_userNavigation { get; set; } = null!;
    }
}

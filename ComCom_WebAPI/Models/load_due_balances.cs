using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class load_due_balances
    {
        public uint id_due_balance { get; set; }
        public string? id_distributor { get; set; }
        public string? date { get; set; }
        public string? due_date { get; set; }
        public string? id_charge_type { get; set; }
        public string? amount { get; set; }
        public string? interest { get; set; }
    }
}

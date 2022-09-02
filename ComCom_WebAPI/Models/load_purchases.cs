using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class load_purchases
    {
        public uint id_purchase { get; set; }
        public string? id_distributor { get; set; }
        public string? id_coupon { get; set; }
        public string? id_customer { get; set; }
        public string? date { get; set; }
        public string? first_due_date { get; set; }
        public string? id_charge_type { get; set; }
        public string? fortnights { get; set; }
        public string? principal { get; set; }
        public string? interest { get; set; }
        public string? id_branch { get; set; }
        public string? id_store { get; set; }
        public string? insurance { get; set; }
    }
}

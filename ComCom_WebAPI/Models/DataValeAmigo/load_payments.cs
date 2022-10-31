using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class load_payments
    {
        public uint id_payment { get; set; }
        public string? id_distributor { get; set; }
        public string? date { get; set; }
        public string? amount { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class load_coupons
    {
        public uint id_coupon { get; set; }
        public string? id_distributor { get; set; }
        public string? num_coupon { get; set; }
        public string? parent { get; set; }
        public string? emission { get; set; }
        public string? expiration { get; set; }
    }
}

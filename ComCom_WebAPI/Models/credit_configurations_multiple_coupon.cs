using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_configurations_multiple_coupon
    {
        public uint id_multiple_coupon { get; set; }
        public string name { get; set; } = null!;
        public int number_renewals { get; set; }
        public int? payment_percentage { get; set; }
        public decimal? credit_line { get; set; }
        public int status { get; set; }
    }
}

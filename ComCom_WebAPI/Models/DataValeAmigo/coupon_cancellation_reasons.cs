using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class coupon_cancellation_reasons
    {
        public uint id_cancellation_reason { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_holidays
    {
        public uint id_holiday { get; set; }
        public byte status { get; set; }
        public DateOnly date { get; set; }
    }
}

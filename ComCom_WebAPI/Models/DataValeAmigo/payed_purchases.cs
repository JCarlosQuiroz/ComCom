using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class payed_purchases
    {
        public uint id_purchase { get; set; }
        public decimal principal { get; set; }
        public decimal interest { get; set; }
        public decimal amount { get; set; }
        public decimal payed { get; set; }
    }
}

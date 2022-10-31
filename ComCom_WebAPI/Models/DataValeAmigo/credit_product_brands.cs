using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_product_brands
    {
        public uint id_product_brand { get; set; }
        public string name { get; set; } = null!;
        public byte status { get; set; }
    }
}

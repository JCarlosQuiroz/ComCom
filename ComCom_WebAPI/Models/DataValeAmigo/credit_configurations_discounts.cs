using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_configurations_discounts
    {
        public int id_configuration_discount { get; set; }
        public string name { get; set; } = null!;
        public sbyte? status { get; set; }
    }
}

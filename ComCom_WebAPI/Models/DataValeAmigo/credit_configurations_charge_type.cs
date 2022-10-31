using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_configurations_charge_type
    {
        public int id_configuration_charge_type { get; set; }
        public string? name { get; set; }
        public DateTime? registered { get; set; }
        public sbyte? status { get; set; }
    }
}

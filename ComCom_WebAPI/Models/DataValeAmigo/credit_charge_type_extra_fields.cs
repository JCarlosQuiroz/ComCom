using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_charge_type_extra_fields
    {
        public int id_charge_type_extra_field { get; set; }
        public int? id_configuration_charge_type { get; set; }
        public int? id_charge_type { get; set; }
        public sbyte? requires_confirmation { get; set; }
        public sbyte? affects_credit_line { get; set; }
        public sbyte? amount_from { get; set; }
        public sbyte? is_simultaneous { get; set; }
        public decimal? amount { get; set; }
    }
}

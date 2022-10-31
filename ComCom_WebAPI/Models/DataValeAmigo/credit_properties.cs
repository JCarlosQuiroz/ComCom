using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_properties
    {
        public uint id_property { get; set; }
        public uint id_distributor { get; set; }
        public uint id_property_type { get; set; }
        public decimal amount { get; set; }
        public string? description { get; set; }
        public string? name { get; set; }
        public byte type { get; set; }
        public string? street { get; set; }
        public string? house_number { get; set; }
        public string? apartment_number { get; set; }
        public string? neighborhood { get; set; }
        public string? settlement { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? zipcode { get; set; }
        public string? status { get; set; }

        public virtual credit_distributors id_distributorNavigation { get; set; } = null!;
        public virtual origination_properties_types id_property_typeNavigation { get; set; } = null!;
    }
}

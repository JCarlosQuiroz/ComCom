using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_properties
    {
        public origination_properties()
        {
            origination_applications_inquiries = new HashSet<origination_applications_inquiries>();
        }

        public uint id_property { get; set; }
        public uint id_property_type { get; set; }
        public uint id_person { get; set; }
        public decimal amount { get; set; }
        public string description { get; set; } = null!;
        public string name { get; set; } = null!;
        public byte? type { get; set; }
        public string? street { get; set; }
        public string? house_number { get; set; }
        public string? apartment_number { get; set; }
        public string? neighborhood { get; set; }
        public string? settlement { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? zipcode { get; set; }

        public virtual origination_persons id_personNavigation { get; set; } = null!;
        public virtual origination_properties_types id_property_typeNavigation { get; set; } = null!;
        public virtual ICollection<origination_applications_inquiries> origination_applications_inquiries { get; set; }
    }
}

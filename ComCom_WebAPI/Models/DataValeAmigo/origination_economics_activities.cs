using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_economics_activities
    {
        public origination_economics_activities()
        {
            origination_applications_inquiries = new HashSet<origination_applications_inquiries>();
            origination_persons = new HashSet<origination_persons>();
        }

        public uint id_economic_activity { get; set; }
        public string? company { get; set; }
        public string? position { get; set; }
        public string? salary { get; set; }
        public string? antiquity { get; set; }
        public string? phone { get; set; }
        public string? street { get; set; }
        public string? house_number { get; set; }
        public string? apartment_number { get; set; }
        public string? neighborhood { get; set; }
        public string? settlement { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? zipcode { get; set; }

        public virtual ICollection<origination_applications_inquiries> origination_applications_inquiries { get; set; }
        public virtual ICollection<origination_persons> origination_persons { get; set; }
    }
}

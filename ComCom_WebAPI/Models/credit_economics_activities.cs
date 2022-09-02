using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_economics_activities
    {
        public credit_economics_activities()
        {
            credit_persons = new HashSet<credit_persons>();
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

        public virtual ICollection<credit_persons> credit_persons { get; set; }
    }
}

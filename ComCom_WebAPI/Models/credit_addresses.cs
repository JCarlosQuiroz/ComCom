using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class credit_addresses
    {
        public credit_addresses()
        {
            credit_persons = new HashSet<credit_persons>();
        }

        public uint id_address { get; set; }
        public string? street { get; set; }
        public string? house_number { get; set; }
        public string? apartment_number { get; set; }
        public string? neighborhood { get; set; }
        public string? settlement { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? zipcode { get; set; }
        public string? latitude { get; set; }
        public string? longitude { get; set; }

        public virtual ICollection<credit_persons> credit_persons { get; set; }
    }
}

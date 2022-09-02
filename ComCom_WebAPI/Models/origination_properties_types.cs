using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_properties_types
    {
        public origination_properties_types()
        {
            credit_properties = new HashSet<credit_properties>();
            origination_properties = new HashSet<origination_properties>();
        }

        public uint id_property_type { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;
        public byte require_address { get; set; }

        public virtual ICollection<credit_properties> credit_properties { get; set; }
        public virtual ICollection<origination_properties> origination_properties { get; set; }
    }
}

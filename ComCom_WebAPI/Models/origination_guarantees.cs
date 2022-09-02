using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_guarantees
    {
        public origination_guarantees()
        {
            origination_applications_inquiries = new HashSet<origination_applications_inquiries>();
        }

        public uint id_guarantee { get; set; }
        public uint id_application { get; set; }
        public uint id_person { get; set; }
        public uint id_relationship { get; set; }
        public byte status { get; set; }
        public DateTime timestamp { get; set; }

        public virtual origination_applications id_applicationNavigation { get; set; } = null!;
        public virtual origination_persons id_personNavigation { get; set; } = null!;
        public virtual origination_relationships id_relationshipNavigation { get; set; } = null!;
        public virtual ICollection<origination_applications_inquiries> origination_applications_inquiries { get; set; }
    }
}

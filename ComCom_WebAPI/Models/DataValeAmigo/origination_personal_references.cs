using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_personal_references
    {
        public origination_personal_references()
        {
            origination_applications_inquiries = new HashSet<origination_applications_inquiries>();
        }

        public uint id_personal_reference { get; set; }
        public uint id_application { get; set; }
        public uint id_relationship { get; set; }
        public uint id_person { get; set; }
        public uint? time { get; set; }
        public byte status { get; set; }

        public virtual origination_applications id_applicationNavigation { get; set; } = null!;
        public virtual origination_persons id_personNavigation { get; set; } = null!;
        public virtual origination_relationships id_relationshipNavigation { get; set; } = null!;
        public virtual ICollection<origination_applications_inquiries> origination_applications_inquiries { get; set; }
    }
}

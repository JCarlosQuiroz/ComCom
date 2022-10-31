using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_persons_phones
    {
        public origination_persons_phones()
        {
            origination_applications_inquiries = new HashSet<origination_applications_inquiries>();
            origination_telephone_inquiries = new HashSet<origination_telephone_inquiries>();
        }

        public uint id_person_phone { get; set; }
        public uint id_phone_type { get; set; }
        public uint id_person { get; set; }
        public byte status { get; set; }
        public string number { get; set; } = null!;

        public virtual origination_persons id_personNavigation { get; set; } = null!;
        public virtual origination_phones_types id_phone_typeNavigation { get; set; } = null!;
        public virtual ICollection<origination_applications_inquiries> origination_applications_inquiries { get; set; }
        public virtual ICollection<origination_telephone_inquiries> origination_telephone_inquiries { get; set; }
    }
}

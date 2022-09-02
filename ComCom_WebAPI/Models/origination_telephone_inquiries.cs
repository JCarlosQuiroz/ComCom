using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_telephone_inquiries
    {
        public origination_telephone_inquiries()
        {
            origination_telephone_inquiries_fields = new HashSet<origination_telephone_inquiries_fields>();
        }

        public uint id_telephone_inquiry { get; set; }
        public uint id_application { get; set; }
        public uint id_person { get; set; }
        public uint id_process { get; set; }
        public uint id_person_phone { get; set; }
        public DateTime datetime { get; set; }
        public byte status { get; set; }
        public string note { get; set; } = null!;
        public uint? id_user { get; set; }

        public virtual origination_applications id_applicationNavigation { get; set; } = null!;
        public virtual origination_persons id_personNavigation { get; set; } = null!;
        public virtual origination_persons_phones id_person_phoneNavigation { get; set; } = null!;
        public virtual origination_processes id_processNavigation { get; set; } = null!;
        public virtual core_users? id_userNavigation { get; set; }
        public virtual ICollection<origination_telephone_inquiries_fields> origination_telephone_inquiries_fields { get; set; }
    }
}

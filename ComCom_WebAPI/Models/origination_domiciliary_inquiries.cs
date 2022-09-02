using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_domiciliary_inquiries
    {
        public origination_domiciliary_inquiries()
        {
            origination_domiciliary_inquiries_fields = new HashSet<origination_domiciliary_inquiries_fields>();
        }

        public uint id_domiciliary_inquiry { get; set; }
        public uint id_application { get; set; }
        public uint id_person { get; set; }
        public uint id_process { get; set; }
        public DateTime datetime { get; set; }
        public byte status { get; set; }
        public string note { get; set; } = null!;
        public uint? id_user { get; set; }

        public virtual origination_applications id_applicationNavigation { get; set; } = null!;
        public virtual origination_persons id_personNavigation { get; set; } = null!;
        public virtual origination_processes id_processNavigation { get; set; } = null!;
        public virtual core_users? id_userNavigation { get; set; }
        public virtual ICollection<origination_domiciliary_inquiries_fields> origination_domiciliary_inquiries_fields { get; set; }
    }
}

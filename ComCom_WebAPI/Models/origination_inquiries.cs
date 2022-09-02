using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_inquiries
    {
        public origination_inquiries()
        {
            origination_applications_inquiries = new HashSet<origination_applications_inquiries>();
            origination_inquiry_fields = new HashSet<origination_inquiry_fields>();
        }

        public uint id_inquiry { get; set; }
        public uint id_process { get; set; }
        public string name { get; set; } = null!;
        public DateTime timestamp { get; set; }
        public byte status { get; set; }
        public string? description { get; set; }
        public sbyte type { get; set; }
        public sbyte person_type { get; set; }

        public virtual origination_processes id_processNavigation { get; set; } = null!;
        public virtual ICollection<origination_applications_inquiries> origination_applications_inquiries { get; set; }
        public virtual ICollection<origination_inquiry_fields> origination_inquiry_fields { get; set; }
    }
}

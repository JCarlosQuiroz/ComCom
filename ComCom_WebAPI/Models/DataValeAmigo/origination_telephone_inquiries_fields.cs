using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_telephone_inquiries_fields
    {
        public uint id_telephone_inquiry_field { get; set; }
        public uint id_telephone_inquiry { get; set; }
        public uint id_process_field { get; set; }
        public string? value { get; set; }

        public virtual origination_processes_fields id_process_fieldNavigation { get; set; } = null!;
        public virtual origination_telephone_inquiries id_telephone_inquiryNavigation { get; set; } = null!;
    }
}

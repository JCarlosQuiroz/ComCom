using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_domiciliary_inquiries_fields
    {
        public uint id_domiciliary_inquiry_field { get; set; }
        public uint id_domiciliary_inquiry { get; set; }
        public uint id_process_field { get; set; }
        public string? value { get; set; }

        public virtual origination_domiciliary_inquiries id_domiciliary_inquiryNavigation { get; set; } = null!;
        public virtual origination_processes_fields id_process_fieldNavigation { get; set; } = null!;
    }
}

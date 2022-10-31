using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_processes_fields
    {
        public origination_processes_fields()
        {
            origination_domiciliary_inquiries_fields = new HashSet<origination_domiciliary_inquiries_fields>();
            origination_telephone_inquiries_fields = new HashSet<origination_telephone_inquiries_fields>();
        }

        public uint id_process_field { get; set; }
        public uint id_process { get; set; }
        public byte status { get; set; }
        public byte entity { get; set; }
        public byte type { get; set; }
        public byte required { get; set; }
        public string name { get; set; } = null!;
        public string? values { get; set; }
        public byte has_comment { get; set; }
        public string? comment_name { get; set; }

        public virtual origination_processes id_processNavigation { get; set; } = null!;
        public virtual ICollection<origination_domiciliary_inquiries_fields> origination_domiciliary_inquiries_fields { get; set; }
        public virtual ICollection<origination_telephone_inquiries_fields> origination_telephone_inquiries_fields { get; set; }
    }
}

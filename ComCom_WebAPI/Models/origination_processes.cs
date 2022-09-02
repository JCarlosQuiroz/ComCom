using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_processes
    {
        public origination_processes()
        {
            origination_domiciliary_inquiries = new HashSet<origination_domiciliary_inquiries>();
            origination_inquiries = new HashSet<origination_inquiries>();
            origination_processes_fields = new HashSet<origination_processes_fields>();
            origination_scorings = new HashSet<origination_scorings>();
            origination_stages_processes = new HashSet<origination_stages_processes>();
            origination_telephone_inquiries = new HashSet<origination_telephone_inquiries>();
            origination_validations = new HashSet<origination_validations>();
        }

        public uint id_process { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;
        public byte type { get; set; }

        public virtual ICollection<origination_domiciliary_inquiries> origination_domiciliary_inquiries { get; set; }
        public virtual ICollection<origination_inquiries> origination_inquiries { get; set; }
        public virtual ICollection<origination_processes_fields> origination_processes_fields { get; set; }
        public virtual ICollection<origination_scorings> origination_scorings { get; set; }
        public virtual ICollection<origination_stages_processes> origination_stages_processes { get; set; }
        public virtual ICollection<origination_telephone_inquiries> origination_telephone_inquiries { get; set; }
        public virtual ICollection<origination_validations> origination_validations { get; set; }
    }
}

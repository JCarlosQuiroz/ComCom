using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_stages_processes
    {
        public origination_stages_processes()
        {
            origination_applications_inquiries = new HashSet<origination_applications_inquiries>();
        }

        public uint id_stage_process { get; set; }
        public uint id_stage { get; set; }
        public uint id_process { get; set; }
        public byte? required { get; set; }
        public byte entity { get; set; }

        public virtual origination_processes id_processNavigation { get; set; } = null!;
        public virtual origination_stages id_stageNavigation { get; set; } = null!;
        public virtual ICollection<origination_applications_inquiries> origination_applications_inquiries { get; set; }
    }
}

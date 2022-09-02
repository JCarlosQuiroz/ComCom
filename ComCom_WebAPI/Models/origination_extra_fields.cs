using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_extra_fields
    {
        public origination_extra_fields()
        {
            credit_distributors_extra_fields = new HashSet<credit_distributors_extra_fields>();
            origination_applications_extra_fields = new HashSet<origination_applications_extra_fields>();
        }

        public uint id_extra_field { get; set; }
        public byte status { get; set; }
        public byte type { get; set; }
        public byte entity { get; set; }
        public byte required { get; set; }
        public string name { get; set; } = null!;
        public string? values { get; set; }

        public virtual ICollection<credit_distributors_extra_fields> credit_distributors_extra_fields { get; set; }
        public virtual ICollection<origination_applications_extra_fields> origination_applications_extra_fields { get; set; }
    }
}

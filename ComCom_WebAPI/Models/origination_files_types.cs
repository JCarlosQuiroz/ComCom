using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_files_types
    {
        public origination_files_types()
        {
            credit_distributors_files = new HashSet<credit_distributors_files>();
            origination_applications_files = new HashSet<origination_applications_files>();
            origination_validations_files = new HashSet<origination_validations_files>();
            id_stage = new HashSet<origination_stages>();
        }

        public uint id_file_type { get; set; }
        public byte status { get; set; }
        public byte required { get; set; }
        public byte entity { get; set; }
        public string name { get; set; } = null!;

        public virtual ICollection<credit_distributors_files> credit_distributors_files { get; set; }
        public virtual ICollection<origination_applications_files> origination_applications_files { get; set; }
        public virtual ICollection<origination_validations_files> origination_validations_files { get; set; }

        public virtual ICollection<origination_stages> id_stage { get; set; }
    }
}

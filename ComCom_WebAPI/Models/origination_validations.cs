using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_validations
    {
        public origination_validations()
        {
            origination_validations_files = new HashSet<origination_validations_files>();
        }

        public uint id_validation { get; set; }
        public uint id_process { get; set; }
        public string name { get; set; } = null!;
        public byte status { get; set; }
        public string? description { get; set; }

        public virtual origination_processes id_processNavigation { get; set; } = null!;
        public virtual ICollection<origination_validations_files> origination_validations_files { get; set; }
    }
}

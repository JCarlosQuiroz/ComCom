using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_cc_statuses
    {
        public origination_cc_statuses()
        {
            origination_cc_matrix = new HashSet<origination_cc_matrix>();
        }

        public uint id_status { get; set; }
        public byte status { get; set; }
        public string code { get; set; } = null!;
        public string name { get; set; } = null!;

        public virtual ICollection<origination_cc_matrix> origination_cc_matrix { get; set; }
    }
}

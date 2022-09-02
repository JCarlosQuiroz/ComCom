using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_cc_amounts
    {
        public origination_cc_amounts()
        {
            origination_cc_matrix = new HashSet<origination_cc_matrix>();
        }

        public uint id_amount { get; set; }
        public byte status { get; set; }
        public string code { get; set; } = null!;
        public string name { get; set; } = null!;

        public virtual ICollection<origination_cc_matrix> origination_cc_matrix { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_rivalries
    {
        public origination_rivalries()
        {
            credit_distributors_rivalries = new HashSet<credit_distributors_rivalries>();
            origination_applications_rivalries = new HashSet<origination_applications_rivalries>();
        }

        public uint id_rivalry { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;
        public decimal amount { get; set; }
        public byte antique { get; set; }

        public virtual ICollection<credit_distributors_rivalries> credit_distributors_rivalries { get; set; }
        public virtual ICollection<origination_applications_rivalries> origination_applications_rivalries { get; set; }
    }
}

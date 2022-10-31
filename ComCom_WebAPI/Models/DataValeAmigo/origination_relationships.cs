using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_relationships
    {
        public origination_relationships()
        {
            credit_guarantees = new HashSet<credit_guarantees>();
            credit_personal_references = new HashSet<credit_personal_references>();
            credit_spouses = new HashSet<credit_spouses>();
            origination_guarantees = new HashSet<origination_guarantees>();
            origination_personal_references = new HashSet<origination_personal_references>();
            origination_spouses = new HashSet<origination_spouses>();
        }

        public uint id_relationship { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;

        public virtual ICollection<credit_guarantees> credit_guarantees { get; set; }
        public virtual ICollection<credit_personal_references> credit_personal_references { get; set; }
        public virtual ICollection<credit_spouses> credit_spouses { get; set; }
        public virtual ICollection<origination_guarantees> origination_guarantees { get; set; }
        public virtual ICollection<origination_personal_references> origination_personal_references { get; set; }
        public virtual ICollection<origination_spouses> origination_spouses { get; set; }
    }
}

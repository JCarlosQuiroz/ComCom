using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_phones_types
    {
        public origination_phones_types()
        {
            credit_phones = new HashSet<credit_phones>();
            origination_persons_phones = new HashSet<origination_persons_phones>();
        }

        public uint id_phone_type { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;

        public virtual ICollection<credit_phones> credit_phones { get; set; }
        public virtual ICollection<origination_persons_phones> origination_persons_phones { get; set; }
    }
}

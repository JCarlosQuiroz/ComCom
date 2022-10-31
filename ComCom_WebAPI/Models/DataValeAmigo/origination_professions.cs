using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class origination_professions
    {
        public origination_professions()
        {
            origination_applications = new HashSet<origination_applications>();
        }

        public uint id_profession { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;
        public byte forbidden { get; set; }

        public virtual ICollection<origination_applications> origination_applications { get; set; }
    }
}

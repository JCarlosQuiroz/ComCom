using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_persons
    {
        public core_persons()
        {
            core_users = new HashSet<core_users>();
        }

        public uint id_person { get; set; }
        public string name { get; set; } = null!;
        public string? middle_name { get; set; }
        public string last_name { get; set; } = null!;
        public string second_last_name { get; set; } = null!;

        public virtual ICollection<core_users> core_users { get; set; }
    }
}

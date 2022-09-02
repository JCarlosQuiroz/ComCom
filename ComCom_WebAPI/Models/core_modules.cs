using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_modules
    {
        public core_modules()
        {
            core_controllers = new HashSet<core_controllers>();
        }

        public uint id_module { get; set; }
        public string name { get; set; } = null!;

        public virtual ICollection<core_controllers> core_controllers { get; set; }
    }
}

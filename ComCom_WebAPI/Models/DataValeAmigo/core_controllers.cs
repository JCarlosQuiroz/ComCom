using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_controllers
    {
        public core_controllers()
        {
            core_actions = new HashSet<core_actions>();
        }

        public uint id_controller { get; set; }
        public uint id_module { get; set; }
        public string name { get; set; } = null!;

        public virtual core_modules id_moduleNavigation { get; set; } = null!;
        public virtual ICollection<core_actions> core_actions { get; set; }
    }
}

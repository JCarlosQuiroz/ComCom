using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_action_groups
    {
        public core_action_groups()
        {
            id_action = new HashSet<core_actions>();
        }

        public uint id_action_group { get; set; }
        public uint id_menu { get; set; }
        public string name { get; set; } = null!;

        public virtual core_menus id_menuNavigation { get; set; } = null!;

        public virtual ICollection<core_actions> id_action { get; set; }
    }
}

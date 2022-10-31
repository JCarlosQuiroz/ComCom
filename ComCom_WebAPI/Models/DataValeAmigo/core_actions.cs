using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_actions
    {
        public core_actions()
        {
            core_menus = new HashSet<core_menus>();
            id_action_group = new HashSet<core_action_groups>();
            id_menu = new HashSet<core_menus>();
            id_role = new HashSet<core_roles>();
        }

        public uint id_action { get; set; }
        public uint id_controller { get; set; }
        public string name { get; set; } = null!;

        public virtual core_controllers id_controllerNavigation { get; set; } = null!;
        public virtual ICollection<core_menus> core_menus { get; set; }

        public virtual ICollection<core_action_groups> id_action_group { get; set; }
        public virtual ICollection<core_menus> id_menu { get; set; }
        public virtual ICollection<core_roles> id_role { get; set; }
    }
}

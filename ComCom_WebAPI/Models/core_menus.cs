using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_menus
    {
        public core_menus()
        {
            Inverseid_parentNavigation = new HashSet<core_menus>();
            core_action_groups = new HashSet<core_action_groups>();
            id_action1 = new HashSet<core_actions>();
        }

        public uint id_menu { get; set; }
        public uint? id_parent { get; set; }
        public uint id_menu_section { get; set; }
        public uint? id_action { get; set; }
        public byte type { get; set; }
        public byte status { get; set; }
        public byte order { get; set; }
        public string icon { get; set; } = null!;
        public string name { get; set; } = null!;
        public byte is_s2next { get; set; }
        public string? url { get; set; }

        public virtual core_actions? id_actionNavigation { get; set; }
        public virtual core_menu_sections id_menu_sectionNavigation { get; set; } = null!;
        public virtual core_menus? id_parentNavigation { get; set; }
        public virtual ICollection<core_menus> Inverseid_parentNavigation { get; set; }
        public virtual ICollection<core_action_groups> core_action_groups { get; set; }

        public virtual ICollection<core_actions> id_action1 { get; set; }
    }
}

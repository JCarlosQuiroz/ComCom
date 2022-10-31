using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_menu_sections
    {
        public core_menu_sections()
        {
            core_menus = new HashSet<core_menus>();
        }

        public uint id_menu_section { get; set; }
        public byte status { get; set; }
        public string name { get; set; } = null!;
        public byte order { get; set; }

        public virtual ICollection<core_menus> core_menus { get; set; }
    }
}

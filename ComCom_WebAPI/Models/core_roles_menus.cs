using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_roles_menus
    {
        public int id_role_menu { get; set; }
        public int id_role { get; set; }
        public int id_menu { get; set; }
    }
}

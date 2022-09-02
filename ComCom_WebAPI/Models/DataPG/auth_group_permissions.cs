using ComCom_WebAPI.Models.DataPG;
using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class auth_group_permissions
    {
        public int id { get; set; }
        public int group_id { get; set; }
        public int permission_id { get; set; }

        public virtual auth_group group { get; set; } = null!;
        public virtual auth_permission permission { get; set; } = null!;
    }
}

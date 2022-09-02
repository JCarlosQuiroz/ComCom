using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class auth_user_user_permissions
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int permission_id { get; set; }

        public virtual auth_permission permission { get; set; } = null!;
        public virtual auth_user user { get; set; } = null!;
    }
}


using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class auth_group
    {
        public auth_group()
        {
            auth_group_permissions = new HashSet<auth_group_permissions>();
            auth_user_groups = new HashSet<auth_user_groups>();
        }

        public int id { get; set; }
        public string name { get; set; } = null!;

        public virtual ICollection<auth_group_permissions> auth_group_permissions { get; set; }
        public virtual ICollection<auth_user_groups> auth_user_groups { get; set; }
    }
}

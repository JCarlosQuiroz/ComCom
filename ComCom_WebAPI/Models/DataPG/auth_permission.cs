using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class auth_permission
    {
        public auth_permission()
        {
            auth_group_permissions = new HashSet<auth_group_permissions>();
            auth_user_user_permissions = new HashSet<auth_user_user_permissions>();
        }

        public int id { get; set; }
        public string name { get; set; } = null!;
        public int content_type_id { get; set; }
        public string codename { get; set; } = null!;

        public virtual django_content_type content_type { get; set; } = null!;
        public virtual ICollection<auth_group_permissions> auth_group_permissions { get; set; }
        public virtual ICollection<auth_user_user_permissions> auth_user_user_permissions { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class django_content_type
    {
        public django_content_type()
        {
            auth_permission = new HashSet<auth_permission>();
            django_admin_log = new HashSet<django_admin_log>();
        }

        public int id { get; set; }
        public string app_label { get; set; } = null!;
        public string model { get; set; } = null!;

        public virtual ICollection<auth_permission> auth_permission { get; set; }
        public virtual ICollection<django_admin_log> django_admin_log { get; set; }
    }
}

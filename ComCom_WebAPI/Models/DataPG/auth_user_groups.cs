using ComCom_WebAPI.Models.DataPG;
using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class auth_user_groups
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int group_id { get; set; }

        public virtual auth_group group { get; set; } = null!;
        public virtual auth_user user { get; set; } = null!;
    }
}

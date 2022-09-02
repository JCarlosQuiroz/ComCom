using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class tower_client
    {
        public int client_ptr_id { get; set; }

        public virtual client client_ptr { get; set; } = null!;
    }
}

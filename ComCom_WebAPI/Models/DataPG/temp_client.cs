using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class temp_client
    {
        public int client_ptr_id { get; set; }
        public DateOnly? expiration_date { get; set; }

        public virtual client client_ptr { get; set; } = null!;
    }
}

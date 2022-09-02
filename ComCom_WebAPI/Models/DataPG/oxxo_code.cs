using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class oxxo_code
    {
        public int id { get; set; }
        public string code { get; set; } = null!;
        public DateOnly created_date { get; set; }
        public DateTime begin_date { get; set; }
        public DateTime end_date { get; set; }
        public int amount { get; set; }
        public int fk_client_id { get; set; }

        public virtual client_wifi_credential fk_client { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class coupon
    {
        public int id { get; set; }
        public int amount { get; set; }
        public DateOnly created_date { get; set; }
        public DateOnly begin_date { get; set; }
        public DateOnly? end_date { get; set; }
        public DateOnly? used_date { get; set; }
        public string type { get; set; } = null!;
        public string status { get; set; } = null!;
        public int fk_client_id { get; set; }

        public virtual client_wifi_credential fk_client { get; set; } = null!;
    }
}

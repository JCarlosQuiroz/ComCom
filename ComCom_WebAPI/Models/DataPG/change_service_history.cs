using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class change_service_history
    {
        public int id { get; set; }
        public string service { get; set; } = null!;
        public double service_full_price { get; set; }
        public double service_full_price_apply { get; set; }
        public DateOnly create_date { get; set; }
        public string type_equivalent { get; set; } = null!;
        public string username { get; set; } = null!;
    }
}

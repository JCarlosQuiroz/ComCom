using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class price_list
    {
        public price_list()
        {
            client = new HashSet<client>();
        }

        public int id { get; set; }
        public string name { get; set; } = null!;
        public double amount { get; set; }
        public DateOnly create_date { get; set; }
        public DateOnly begin_date { get; set; }
        public DateOnly? end_date { get; set; }
        public bool endless { get; set; }
        public bool default_price { get; set; }
        public string? description { get; set; }
        public int? fk_service { get; set; }
        public bool is_active { get; set; }
        public int? fk_zone_id { get; set; }

        public virtual zone? fk_zone { get; set; }
        public virtual ICollection<client> client { get; set; }
    }
}

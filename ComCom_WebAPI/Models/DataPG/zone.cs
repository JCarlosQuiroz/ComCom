using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class zone
    {
        public zone()
        {
            client = new HashSet<client>();
            price_list = new HashSet<price_list>();
            zone_category_fk_zone = new HashSet<zone_category_fk_zone>();
        }

        public int id { get; set; }
        public string name { get; set; } = null!;
        public double installation_price { get; set; }
        public bool is_active { get; set; }

        public virtual ICollection<client> client { get; set; }
        public virtual ICollection<price_list> price_list { get; set; }
        public virtual ICollection<zone_category_fk_zone> zone_category_fk_zone { get; set; }
    }
}

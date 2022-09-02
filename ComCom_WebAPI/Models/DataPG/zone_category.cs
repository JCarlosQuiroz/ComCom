using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class zone_category
    {
        public zone_category()
        {
            zone_category_fk_zone = new HashSet<zone_category_fk_zone>();
        }

        public int id { get; set; }
        public string name { get; set; } = null!;
        public string type { get; set; } = null!;
        public bool is_active { get; set; }

        public virtual ICollection<zone_category_fk_zone> zone_category_fk_zone { get; set; }
    }
}

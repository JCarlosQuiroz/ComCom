using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class zone_category_fk_zone
    {
        public int id { get; set; }
        public int zonecategory_id { get; set; }
        public int zone_id { get; set; }

        public virtual zone zone { get; set; } = null!;
        public virtual zone_category zonecategory { get; set; } = null!;
    }
}

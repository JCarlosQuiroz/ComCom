using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class manager_business_client
    {
        public manager_business_client()
        {
            business_client = new HashSet<business_client>();
        }

        public int id { get; set; }
        public string name { get; set; } = null!;
        public bool central_manager_collections { get; set; }
        public int? fk_deposit_manager_id { get; set; }

        public virtual deposit? fk_deposit_manager { get; set; }
        public virtual ICollection<business_client> business_client { get; set; }
    }
}

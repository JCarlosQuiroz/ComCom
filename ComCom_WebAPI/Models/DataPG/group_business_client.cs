using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class group_business_client
    {
        public group_business_client()
        {
            group_business_client_fk_business_client = new HashSet<group_business_client_fk_business_client>();
        }

        public int id { get; set; }
        public string name { get; set; } = null!;
        public bool is_active { get; set; }

        public virtual ICollection<group_business_client_fk_business_client> group_business_client_fk_business_client { get; set; }
    }
}

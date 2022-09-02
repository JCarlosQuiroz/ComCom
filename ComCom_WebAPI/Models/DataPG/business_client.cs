using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class business_client
    {
        public business_client()
        {
            group_business_client_fk_business_client = new HashSet<group_business_client_fk_business_client>();
        }

        public int client_ptr_id { get; set; }
        public string commercial_name { get; set; } = null!;
        public string business_name { get; set; } = null!;
        public string? fiscal_reference_number { get; set; }
        public string business_type { get; set; } = null!;
        public int? fk_manager_business_client_id { get; set; }

        public virtual client client_ptr { get; set; } = null!;
        public virtual manager_business_client? fk_manager_business_client { get; set; }
        public virtual ICollection<group_business_client_fk_business_client> group_business_client_fk_business_client { get; set; }
    }
}

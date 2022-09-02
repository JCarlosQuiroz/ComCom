using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class group_business_client_fk_business_client
    {
        public int id { get; set; }
        public int groupbusinessclient_id { get; set; }
        public int businessclient_id { get; set; }

        public virtual business_client businessclient { get; set; } = null!;
        public virtual group_business_client groupbusinessclient { get; set; } = null!;
    }
}

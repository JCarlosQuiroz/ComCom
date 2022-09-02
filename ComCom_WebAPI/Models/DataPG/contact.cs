using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class contact
    {
        public int id { get; set; }
        public string type { get; set; } = null!;
        public string? value { get; set; }
        public string owner { get; set; } = null!;
        public int fk_client_id { get; set; }

        public virtual client fk_client { get; set; } = null!;
    }
}

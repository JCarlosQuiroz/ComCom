using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class service_status
    {
        public service_status()
        {
            client = new HashSet<client>();
        }

        public int id { get; set; }
        public string? key { get; set; }
        public string? value { get; set; }
        public bool is_active { get; set; }

        public virtual ICollection<client> client { get; set; }
    }
}

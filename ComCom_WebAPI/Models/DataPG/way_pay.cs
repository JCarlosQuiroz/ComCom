using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class way_pay
    {
        public way_pay()
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

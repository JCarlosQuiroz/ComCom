using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class load_credits
    {
        public long id_distributor { get; set; }
        public string? id_credit_type { get; set; }
        public string? id_configuration { get; set; }
        public string? authorized { get; set; }
        public string? initial { get; set; }
        public string? current { get; set; }
        public string? preauthorized { get; set; }
        public string? promisory_note { get; set; }
        public string? maximum { get; set; }
    }
}

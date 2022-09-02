using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class nas
    {
        public int id { get; set; }
        public string nasname { get; set; } = null!;
        public string? shortname { get; set; }
        public string? type { get; set; }
        public int? ports { get; set; }
        public string secret { get; set; } = null!;
        public string? community { get; set; }
        public string? description { get; set; }
        public string starospassword { get; set; } = null!;
        public bool ciscobwmode { get; set; }
        public string apiusername { get; set; } = null!;
        public string apipassword { get; set; } = null!;
        public int apiver { get; set; }
        public bool coamode { get; set; }
    }
}

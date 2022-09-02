using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class webhook_response
    {
        public int id { get; set; }
        public string code { get; set; } = null!;
        public DateOnly created_date { get; set; }
        public string type { get; set; } = null!;
    }
}

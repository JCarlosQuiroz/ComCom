using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class client_error_disconnect
    {
        public int id { get; set; }
        public string username { get; set; } = null!;
        public string host { get; set; } = null!;
        public string? error { get; set; }
        public int tries { get; set; }
        public DateOnly create_date { get; set; }
    }
}

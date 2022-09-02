using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class unsubscribe_temp_client
    {
        public int id { get; set; }
        public string username { get; set; } = null!;
        public string firstname { get; set; } = null!;
        public string lastname { get; set; } = null!;
        public string phone { get; set; } = null!;
        public string mobile { get; set; } = null!;
        public string address { get; set; } = null!;
        public DateOnly? expiration_date { get; set; }
        public DateOnly? created_date { get; set; }
    }
}

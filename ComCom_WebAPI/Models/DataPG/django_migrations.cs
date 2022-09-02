using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class django_migrations
    {
        public int id { get; set; }
        public string app { get; set; } = null!;
        public string name { get; set; } = null!;
        public DateTime applied { get; set; }
    }
}

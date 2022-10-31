using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataValeAmigo
{
    public partial class app_logs
    {
        public uint id_log { get; set; }
        public DateTime? timestamp { get; set; }
        public string? priority { get; set; }
        public string? message { get; set; }
        public int? id_user { get; set; }
        public string? ip { get; set; }
    }
}

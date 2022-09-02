using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataPG
{
    public partial class file_report
    {
        public int id { get; set; }
        public string imported_file { get; set; } = null!;
        public DateOnly created_date { get; set; }
        public string created_by { get; set; } = null!;
        public string type { get; set; } = null!;
    }
}

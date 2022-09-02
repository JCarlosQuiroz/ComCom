using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class core_apps_versions
    {
        public int id_app_version { get; set; }
        public string? name { get; set; }
        public string? version { get; set; }
        public sbyte? status { get; set; }
    }
}

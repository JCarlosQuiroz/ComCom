using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models.DataMS
{
    public partial class rm_phpsess
    {
        public string managername { get; set; } = null!;
        public string ip { get; set; } = null!;
        public string sessid { get; set; } = null!;
        public DateTime lastact { get; set; }
        public bool? closed { get; set; }
    }
}
